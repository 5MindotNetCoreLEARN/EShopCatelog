using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Services
{
    public interface ICatalogService
    {
        Task AddNewItem(CatalogItem item);
        Task<List<CatalogItem>> GetCatalog();
    }
}
