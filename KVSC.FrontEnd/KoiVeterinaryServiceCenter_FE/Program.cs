using KoiVeterinaryServiceCenter_FE.StartUp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.RegisterServices(builder.Configuration);

// Configure Cookie Policy
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Lax; // Use Lax or Strict
    options.Secure = CookieSecurePolicy.Always; // Ensure cookies are sent only over HTTPS
});
//builder.Services.AddControllers()
//    .AddJsonOptions(options =>
//    {
//        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
//    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts(); // Enable HSTS for production
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Use Cookie Policy middleware
app.UseCookiePolicy();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
