using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Abstract;

namespace WebApiVehicle.DAL.Repositories.Interfaces.Abstract
{
    public interface IVehicleRepo<T> where T: Vehicle
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetDefaults(Expression<Func<T, bool>> expression);
    }
}
