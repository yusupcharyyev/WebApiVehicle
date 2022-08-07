using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Abstract;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.Models.Entities.Concrete
{
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public int TireCount { get; set; }
    }
}
