﻿using EndProject.API.Contexts;
using EndProject.API.Models.DTO;
using EndProject.API.Repositories.MainRepositorie;

namespace EndProject.API.Repositories
{
    public class ItemRepository : RepositoryBase<Items>, IitemRepository
    {
        public ItemRepository(MainContex _contex) : base(_contex)
        { }
    }
}




