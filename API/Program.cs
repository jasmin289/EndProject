using EndProject.API.Contexts;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddDbContext<MainContex>(o => {
                o.UseSqlServer(builder.Configuration.GetConnectionString("MainDb"));
            });
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //this code make sure that the DB is up to date every time the api start.
            using (var scop = app.Services.CreateScope())
            {
                var context = scop.ServiceProvider.GetRequiredService<MainContex>();
                context.Database.Migrate(); 
            }

            // Configure the HTTP request pipeline.
           
                app.UseSwagger();
                app.UseSwaggerUI();
           

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}