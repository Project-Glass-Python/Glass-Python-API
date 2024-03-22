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
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "nike", 44.99m),
            };

            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            Item item = new Item("Shirt", "Ohio State shirt.", "nike", 29.99m);
            item.Id = id;
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            Item item = new Item("Shirt", "Ohio State shirt.", "nike", 29.99m);
            item.Id = id;
            item.AddRating(rating);
            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id, Item item)
        {
            return NoContent();
        }
    }
}