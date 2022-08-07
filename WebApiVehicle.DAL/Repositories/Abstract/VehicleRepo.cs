using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.DAL.Context;
using WebApiVehicle.DAL.Repositories.Interfaces.Abstract;
using WebApiVehicle.Models.Entities.Abstract;
using WebApiVehicle.Models.Entities.Concrete;
using WebApiVehicle.Models.Enums;

namespace WebApiVehicle.DAL.Repositories.Abstract
{
    public abstract class VehicleRepo<T> : IVehicleRepo<T> where T : Vehicle
    {
        private readonly ProjectContext _projectContext;
        protected readonly DbSet<T> _table;

        public VehicleRepo(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = projectContext.Set<T>();
        }


        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        T IVehicleRepo<T>.Create(T entity)
        {
            _table.Add(entity);
            _projectContext.SaveChanges();
            return entity;
        }

        T IVehicleRepo<T>.Delete(T entity)
        {
            entity.Statu = Statu.Passive;
            entity.RemoveDate = DateTime.Now;
            _projectContext.SaveChanges();
            return entity;
        }
        T IVehicleRepo<T>.Update(T entity)
        {
            entity.Statu = Statu.Modified;
            entity.ModifiedDate = DateTime.Now;
            _table.Update(entity);
            _projectContext.SaveChanges();
            return entity;
        }

    }
}
