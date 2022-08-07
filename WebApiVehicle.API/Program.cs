using Microsoft.EntityFrameworkCore;
using WebApiVehicle.DAL.Context;
using WebApiVehicle.DAL.Repositories.Concrete;
using WebApiVehicle.DAL.Repositories.Interfaces.Concrete;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<ProjectContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseLazyLoadingProxies(true);
});

builder.Services.AddScoped<ICarRepo, CarRepo>();
builder.Services.AddScoped<IBuseRepo, BuseRepo>();
builder.Services.AddScoped<IBoatRepo, BoatRepo>();



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
}

app.UseAuthorization();

app.MapControllers();

SeedData.Seed(app);
app.Run();
