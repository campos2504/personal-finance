using Domain.Interfaces.Generics;
using Entities.Entites;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//get string
builder.Services.AddDbContext<BaseContext>(options => 
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>(options=>
options.SignIn.RequireConfirmedAccount=true)
    .AddEntityFrameworkStores<BaseContext>();

//depedence injection
builder.Services.AddSingleton(typeof(IGenerics<>), typeof(GenericsRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
