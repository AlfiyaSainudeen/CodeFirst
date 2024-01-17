using Ocelot.DependencyInjection;
using Ocelot.Middleware;
namespace SMSGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("json.json", optional: false, reloadOnChange: true);
            builder.Services.AddOcelot(builder.Configuration);//register ocelete to di
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.UseOcelot();//configure ocelot to the middleware
            app.Run();
            
        }
    }
}
