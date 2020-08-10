using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Infrastructure.Services;
using EShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private ICatalogService _catalogService;

        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet, Route("")]
        public IActionResult Get()
        {
            return Ok("I'm Alive");
        }

        [HttpPost, Route("Add")]
        public async Task<IActionResult> AddAsync(CatalogItem item)
        {
            await _catalogService.AddNewItem(item);

            return Ok(item);
        }

        [HttpGet, Route("GetCatalog")]
        public async Task<IActionResult> GetCatalogAsync()
        {
            var list = await _catalogService.GetCatalog();

            return Ok(list);
        }
    }
}