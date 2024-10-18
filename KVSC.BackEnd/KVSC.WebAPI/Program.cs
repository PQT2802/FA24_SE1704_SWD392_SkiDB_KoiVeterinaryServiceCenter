using KVSC.Infrastructure.DB;

using KVSC.WebAPI.Startup;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<KVSCContext>(opt =>
{
    // Set up your database connection string
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MyDb"));
});
//Google-signin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins("https://localhost:7241")
               .AllowAnyHeader()
               .AllowAnyMethod());
});


//authorize

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true, // Ensures token is not expired
        ValidateIssuerSigningKey = true, // Validates the signature with the signing key
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ClockSkew = TimeSpan.Zero // Optional: Reduces time tolerance when validating token expiration
    };
});
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
    options.AddPolicy("CustomerOnly", policy => policy.RequireRole("Customer"));
    options.AddPolicy("StaffOnly", policy => policy.RequireRole("Staff"));
    options.AddPolicy("VeterinarianOnly", policy => policy.RequireRole("Veterinarian"));
    options.AddPolicy("ManagerOnly", policy => policy.RequireRole("Manager"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});



builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        options.JsonSerializerOptions.MaxDepth = 64;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });



builder.Services.AddHttpContextAccessor();

builder.Services.RegisterServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder
            .WithOrigins("https://localhost:7241") // Allow your front-end origin
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



var logger = app.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("App is starting...");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MigrateDatabases();
app.MapControllers();

app.Run();
