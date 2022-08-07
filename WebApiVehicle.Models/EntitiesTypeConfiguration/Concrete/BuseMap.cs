using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Concrete;
using WebApiVehicle.Models.EntitiesTypeConfiguration.Abstract;

namespace WebApiVehicle.Models.EntitiesTypeConfiguration.Concrete
{
    public class BuseMap:VehicleMap<Buse>
    {
        public override void Configure(EntityTypeBuilder<Buse> builder)
        {
            builder.Property(a => a.Model).IsRequired(true);
            builder.Property(a => a.Switchs).IsRequired(true);
            base.Configure(builder);
        }
    }
}
