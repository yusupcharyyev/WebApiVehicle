using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Abstract;

namespace WebApiVehicle.Models.EntitiesTypeConfiguration.Abstract
{
    public abstract class VehicleMap<T> : IEntityTypeConfiguration<T> where T : Vehicle
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.CreateDate).IsRequired(true);
            builder.Property(a => a.ModifiedDate).IsRequired(false);
            builder.Property(a => a.RemoveDate).IsRequired(false);
            builder.Property(a => a.Statu).IsRequired(true);
            builder.Property(a => a.Color).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Brand).HasMaxLength(40).IsRequired(true);
        }
    }
}
