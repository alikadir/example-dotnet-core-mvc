using Microsoft.AspNetCore.Builder;

namespace FirstDotnetCoreMVC.Middlewares
{
    public static class SampleMiddleware
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder app)
        {

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Server", "Dotnet Core");
                await next.Invoke();
            });
            
            return app;
        }
    }
}