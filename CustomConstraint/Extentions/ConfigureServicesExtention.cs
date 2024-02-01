using CustomConstraint.Constraint;

namespace CustomConstraint.Extentions
{
    public static class ConfigureServicesExtention
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
            builder.Services.Configure<RouteOptions>(x =>
            x.ConstraintMap.Add("nationalNo", typeof(NationalNoConstraint))
            );
            return builder.Build();
        }
        public static WebApplication ConfigurePipline(this WebApplication app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.MapGet("/RouteTesting/{natinalno:nationalNo}", async (context) =>
            {
                foreach(var item in context.Request.RouteValues)
                {
                   await context.Response.WriteAsync($"{item.Key}:{item.Value}");
                }
            });
            return app;
        }
    }
}
