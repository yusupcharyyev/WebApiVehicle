using Microsoft.AspNetCore.Mvc;
using WebApiVehicle.DAL.Repositories.Interfaces.Concrete;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuseController : Controller
    {
        private readonly IBuseRepo _buseRepo;

        public BuseController(IBuseRepo buseRepo)
        {
            _buseRepo = buseRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Car = _buseRepo.GetDefaults(a => a.Statu != Statu.Passive);
            return Ok(Car);
        }

        [HttpGet]
        [Route("[action]/{color}")]
        public IActionResult GetBuseByColor(string color)
        {
            var byColor = _buseRepo.GetDefaults(a => a.Color == color);
            if (byColor != null)
            {
                return Ok(byColor);
            }
            return NotFound();
        }
    }
}
