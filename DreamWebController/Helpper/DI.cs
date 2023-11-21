using DreamWebService.Service;

namespace DreamWebController.Helpper
{
    public static class DI
    {
        public static void ServiceDI(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();
        }

    }
}
