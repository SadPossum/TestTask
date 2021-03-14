using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BackendProject
{
    public class Startup
    {
        readonly private string AllCors = "All";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy(AllCors, build => build.AllowAnyHeader()
                                                                                 .AllowAnyOrigin()
                                                                                 .AllowAnyMethod()));
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(AllCors);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
