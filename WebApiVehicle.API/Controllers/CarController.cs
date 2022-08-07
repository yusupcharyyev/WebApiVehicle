using Microsoft.AspNetCore.Mvc;
using WebApiVehicle.API.headlights;
using WebApiVehicle.DAL.Repositories.Interfaces.Concrete;
using WebApiVehicle.Models.Entities.Concrete;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarRepo _carRepo;

        public CarController(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var Car = _carRepo.GetDefaults(a => a.Statu != Statu.Passive);
            return Ok(Car);
        }

        [HttpGet]
        [Route("[action]/{color}")]
        public IActionResult GetCarByColor(string color)
        {
            var byColor = _carRepo.GetDefaults(a => a.Color == color);
            if (byColor != null)
            {
                return Ok(byColor);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult SwitchOnOff([FromBody] SwitchOnOff parametre)
        {
            Car car = _carRepo.GetDefault(a => a.ID == parametre.id);
            if (car!= null && parametre.Switch=="On")
            {
                car.Switchs = Switchs.On;
                return Ok(_carRepo.Update(car));
            }
            else if(car!=null && parametre.Switch=="Off")
            {
                car.Switchs = Switchs.Off;
                return Ok(_carRepo.Update(car));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult ByDelete(Guid id)
        {
            Car car = _carRepo.GetDefault(a => a.ID == id);
            if (car != null)
            {
                return Ok(_carRepo.Delete(car));
            }
            return NotFound();
        }
    }
}
