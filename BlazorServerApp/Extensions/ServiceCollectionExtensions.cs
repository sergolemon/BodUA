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
    }
}
