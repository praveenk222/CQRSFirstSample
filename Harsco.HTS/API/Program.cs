using API.Extentions;
using Application.Activites;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));
//replaced with extention class service di
builder.Services.AddApplicationServices(builder.Configuration);
//builder.Services.AddDbContext<dbtatContext>(opt =>
//{
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("con"));
//});
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options =>
    {
        options.AllowAnyOrigin()
        .AllowAnyMethod() //AllowAllMethods;  
        .AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");
app.UseAuthorization();

app.MapControllers();

app.Run();
