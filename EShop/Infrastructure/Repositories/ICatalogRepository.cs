using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Repositories
{
    public interface ICatalogRepository
    {
        Task AddItem(CatalogItem item);
        Task<List<CatalogItem>> GetCatalogItems();
    }
}
