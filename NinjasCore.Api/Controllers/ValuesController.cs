using Microsoft.AspNetCore.Mvc;
using NinjasCore.Core;
using NinjasCore.Data;

namespace NinjasCore.Api.Controllers
{
    [Route("api/ninja")]
    public class NinjaController : Controller
    {

        INinja _ninjaService;

        public NinjaController()
        {
            _ninjaService = new SimpleNinja();
        }

        [HttpGet]
        public IActionResult GetNina()
        {
            return Ok(_ninjaService.GetNinja());
        }


    }
}
