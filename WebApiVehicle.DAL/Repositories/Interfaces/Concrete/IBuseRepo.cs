using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.DAL.Repositories.Interfaces.Abstract;
using WebApiVehicle.Models.Entities.Concrete;

namespace WebApiVehicle.DAL.Repositories.Interfaces.Concrete
{
    public interface IBuseRepo:IVehicleRepo<Buse>
    {
    }
}
