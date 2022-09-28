using Microsoft.AspNetCore.Mvc;

namespace PokemonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            try
            {

                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
