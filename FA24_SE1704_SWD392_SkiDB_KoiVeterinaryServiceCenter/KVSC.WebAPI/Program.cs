using KVSC.Infrastructure.DB;
using KVSC.WebAPI.Startup;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<KVSCContext>(opt =>
{
    // opt.UseSqlServer(builder.Configuration.GetConnectionString("Azure"));
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MyDb"));

}

);





builder.Services.AddControllers();
//.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UserValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.RegisterServices();
//builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigureSwagger();

app.UseHttpsRedirection();

//app.UseMiddleware<ValidationMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
