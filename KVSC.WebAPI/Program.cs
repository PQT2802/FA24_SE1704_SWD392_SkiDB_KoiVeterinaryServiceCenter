using FluentValidation;
using FluentValidation.AspNetCore;
using KVSC.Application.KVSC.Application.Common.Validator;
using KVSC.Domain.Entities.User;
using KVSC.Infrastructure.Middleware;
using KVSC.WebAPI.Startup;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UserValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.RegisterServices();
//builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigureSwagger();

app.UseHttpsRedirection();

app.UseMiddleware<ValidationMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
