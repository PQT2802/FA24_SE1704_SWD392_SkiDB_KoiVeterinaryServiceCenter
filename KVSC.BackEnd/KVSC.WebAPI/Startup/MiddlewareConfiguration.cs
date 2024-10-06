using KVSC.Infrastructure.KVSC.Infrastructure.Middleware;
using System.Runtime.CompilerServices;

namespace KVSC.WebAPI.Startup
{
    public static class MiddlewareConfiguration
    {
        public static WebApplication ConfigureMiddleware (this WebApplication app)
        {
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            return app;
        }
    }
}
