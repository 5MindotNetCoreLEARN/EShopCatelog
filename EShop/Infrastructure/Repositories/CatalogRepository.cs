using EShop.Infrastructure.Data;
using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace EShop.Infrastructure.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private CatalogDbContext _db;

        public CatalogRepository(CatalogDbContext db)
        {
            _db = db;
        }

        public async Task AddItem(CatalogItem item)
        {
            await _db.CatalogItems.InsertOneAsync(item);
        }

        public async Task<List<CatalogItem>> GetCatalogItems()
        {
            FilterDefinition<CatalogItem> filter = Builders<CatalogItem>.Filter.Where
                   (c => c.AvailableStock > 0);
            var result = await _db.CatalogItems.FindAsync<CatalogItem>(filter);
            return result.ToList();
        }
    }
}
