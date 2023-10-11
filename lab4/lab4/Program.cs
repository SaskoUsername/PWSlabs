using Microsoft.AspNetCore.Mvc;

namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();


        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template:
               "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}