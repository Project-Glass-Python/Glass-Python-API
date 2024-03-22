using Microsoft.AspNetCore.Mvc;
using Glass.Python.Domain.Catalog;
using System.Runtime.Versioning;

namespace Glass.Python.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello World");
        }
    }
}