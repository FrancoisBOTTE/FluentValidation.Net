using FluentValidation.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody]CoffeeModel coffee)
        {
            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);
            
            return Ok(coffee);
        }
    }
}
