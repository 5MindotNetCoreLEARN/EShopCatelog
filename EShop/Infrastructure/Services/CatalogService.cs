using EShop.Infrastructure.Repositories;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Services
{
    public class CatalogService : ICatalogService
    {
        private ICatalogRepository _catalogRepository;

        public CatalogService(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        public async Task AddNewItem(CatalogItem item)
        {
            await _catalogRepository.AddItem(item);
        }

        public async Task<List<CatalogItem>> GetCatalog()
        {
            return await _catalogRepository.GetCatalogItems();
        }
    }
}
