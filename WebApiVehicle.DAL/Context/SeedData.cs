
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiVehicle.Models.Entities.Concrete;

namespace WebApiVehicle.DAL.Context
{
    public class SeedData
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProjectContext>();
                context.Database.EnsureCreated();
                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<Car>
                    {
                        new Car()
                        {
                            ID=Guid.NewGuid(),
                            Brand="Toyota",
                            Color="White",
                            Model="Avalon",
                            TireCount=4
                        },
                        new Car()
                        {
                            ID=Guid.NewGuid(),
                            Brand="BMW",
                            Color="Red",
                            Model="X5",
                            TireCount=4
                        },
                        new Car()
                        {
                            ID=Guid.NewGuid(),
                            Brand="Mercedes",
                            Color="Blue",
                            Model="SLC",
                            TireCount=4
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Buses.Any())
                {
                    context.Buses.AddRange(new List<Buse>
                    {
                        new Buse()
                        {
                            ID=Guid.NewGuid(),
                            Brand="Volvo",
                            Color="Black",
                            Model="9700DD"
                        },
                        new Buse()
                        {
                            ID=Guid.NewGuid(),
                            Brand="BMC",
                            Color="Yellow",
                            Model="12MCNG"
                        },
                        new Buse()
                        {
                            ID=Guid.NewGuid(),
                            Brand="hyundai",
                            Color="Red",
                            Model="ElecCity"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Boats.Any())
                {
                    context.Boats.AddRange(new List<Boat>
                    {
                        new Boat()
                        {
                            ID=Guid.NewGuid(),
                            Brand="ACM",
                            Color="White",
                            Model="Yanmar"
                        },
                        new Boat()
                        {
                            ID=Guid.NewGuid(),
                            Brand="Altair",
                            Color="blue",
                            Model="Zafir"
                        },
                        new Boat()
                        {
                            ID=Guid.NewGuid(),
                            Brand="AXIS",
                            Color="Red",
                            Model="A20"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
