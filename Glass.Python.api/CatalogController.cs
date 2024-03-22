using Microsoft.AspNetCore.Mvc;
using Glass.Python.Domain.Catalog;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Glass.Python.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        [Route("/catalog")]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "nike", 44.99m),
            };

            return Ok(items);
        }
    }
}