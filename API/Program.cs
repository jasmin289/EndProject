using EndProject.API.Contexts;
using EndProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors();

            builder.Services.AddDbContext<MainContex>(o => {
                o.UseSqlServer(builder.Configuration.GetConnectionString("MainDb"));
            });
            // Add services to the container.
            builder.Services.AddScoped<ICommunicationRepository, CommunicationRepository>();
            builder.Services.AddScoped<IEducationRepository, EducationRepository>();
            builder.Services.AddScoped<IExperienceRepository,ExperienceRepository>();
            builder.Services.AddScoped<IGeneralRepository,GeneralRepository>();
            builder.Services.AddScoped<IHobbyRepository,HobbyRepository>();
            builder.Services.AddScoped<ILanguageRepository,LanguageRepository>();
            builder.Services.AddScoped<IPersonalAttributesRepository,PersonalAttributesRepository>();
            builder.Services.AddScoped<IProgramingSkillsRepository,ProgramingSkillsRepository>();
            builder.Services.AddScoped<IProjectRepository,ProjectRepository>();
            builder.Services.AddScoped<IProjectGallryRepository,ProjectGallryRepository>();
            builder.Services.AddScoped<ISocialNetWorkRepository,SocialNetWorkRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IitemRepository, ItemRepository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //use the appsetting.json 3:01 
            //https:
            //us06web.zoom.us/rec/play/sfio0gonHe0ZP2xzHYp9KJTn7qO7wK62JiWO8sRM6oMKbDkYO3VFd8NOhgS368JMQsM7ZqjCBOOL-Hg.K7HUy55pQnGaqz8E
            builder.Services.AddAuthentication("Bearer").AddJwtBearer(o =>

            o.TokenValidationParameters = new()
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateIssuerSigningKey = true,
                ValidAudience = builder.Configuration["Authentication:Audience"]?? throw new ArgumentNullException("Authentication:Audience"),
                ValidIssuer = builder.Configuration["Authentication:Issuer"]?? throw new ArgumentNullException("Authentication:Issuer"),
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentication:Secret"] ?? throw new ArgumentNullException("Authentication:Issuer")))
            });

            var app = builder.Build();

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());


            //this code make sure that the DB is up to date every time the api start.
            using (var scop = app.Services.CreateScope())
            {
                var context = scop.ServiceProvider.GetRequiredService<MainContex>();
                context.Database.Migrate(); 
            }

            // Configure the HTTP request pipeline.

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}