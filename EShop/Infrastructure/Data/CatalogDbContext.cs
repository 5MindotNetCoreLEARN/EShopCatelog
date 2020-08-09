using EShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {

        private readonly IMongoDatabase _db = null;

        public CatalogDbContext(IOptions<DBConfig> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null) _db = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<CatalogItem> CatalogItems { get { return _db.GetCollection<CatalogItem>("CatalogItem"); } }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

    public class DBConfig
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
