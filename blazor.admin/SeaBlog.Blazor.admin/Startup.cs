using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using SeaBlog.Blazor.Admin.Api.Apis;
using SeaBlog.Blazor.Admin.Api.IApis;

namespace SeaBlog.Blazor.Admin
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserApi, UserApi>();
            services.AddScoped<IBlogApi, BlogApi>();
            services.AddScoped<ICategoryApi, CategoryApi>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
