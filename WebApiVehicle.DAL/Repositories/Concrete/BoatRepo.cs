using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.DAL.Context;
using WebApiVehicle.DAL.Repositories.Abstract;
using WebApiVehicle.DAL.Repositories.Interfaces.Concrete;
using WebApiVehicle.Models.Entities.Concrete;

namespace WebApiVehicle.DAL.Repositories.Concrete
{
    public class BoatRepo : VehicleRepo<Boat>, IBoatRepo
    {
        public BoatRepo(ProjectContext projectContext) : base(projectContext)
        {
        }
    }
}
