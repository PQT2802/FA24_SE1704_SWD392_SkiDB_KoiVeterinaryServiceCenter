using KoiVeterinaryServiceCenter_FE.StartUp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.RegisterServices(builder.Configuration);

// Add session services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true; // Make the session cookie HTTP-only for security
    options.Cookie.IsEssential = true; // Ensure session cookie is always stored
});

// Configure Cookie Policy
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Lax; // Use Lax or Strict
    options.Secure = CookieSecurePolicy.Always; // Ensure cookies are sent only over HTTPS
});

// Build the app
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

// Use session before authorization
app.UseSession(); // Enable session middleware

// Use Cookie Policy middleware
app.UseCookiePolicy();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
