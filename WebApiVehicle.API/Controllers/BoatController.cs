using Microsoft.AspNetCore.Mvc;
using WebApiVehicle.DAL.Repositories.Interfaces.Concrete;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : Controller
    {
        private readonly IBoatRepo _boatRepo;

        public BoatController(IBoatRepo boatRepo)
        {
            _boatRepo = boatRepo;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var Car = _boatRepo.GetDefaults(a => a.Statu != Statu.Passive);
            return Ok(Car);
        }


        [HttpGet]
        [Route("[action]/{color}")]
        public IActionResult GetBoatByColor(string color)
        {
            var byColor = _boatRepo.GetDefaults(a => a.Color == color);
            if (byColor != null)
            {
                return Ok(byColor);
            }
            return NotFound();
        }
    }
}
