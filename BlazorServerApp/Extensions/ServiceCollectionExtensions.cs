using BlazorServerApp.Areas.Admin.ViewModels.Login;
using BlazorServerApp.ViewModels.Catalog;

namespace BlazorServerApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRazorPages(opts =>
            {
                opts.RootDirectory = "/";
            });
            services.AddServerSideBlazor();

            return services;
        }

        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddTransient<LoginVm>();
            services.AddTransient<CatalogVm>();

            return services;
        }
    }
}
