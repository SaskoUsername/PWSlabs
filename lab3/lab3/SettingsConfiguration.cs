using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace lab3
{
    public class SettingsConfiguration
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                context.Items["text"] = "Text from HttpContext.Items";
            await next.Invoke();
            });
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; harset = utf - 8";
                await context.Response.WriteAsync($"Текст { context.Items["text"]} ");
            });
        }
    }
}
