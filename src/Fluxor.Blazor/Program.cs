namespace Fluxor.Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://sampleapi") });

            builder.Services.AddFluxor(o =>
                {
                    o.ScanAssemblies(typeof(Program).Assembly);
#if DEBUG
                    o.UseReduxDevTools();
#endif
                }
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}