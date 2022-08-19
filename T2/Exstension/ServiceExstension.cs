using System.Reflection;
using T2.Interfaces.Services;
using T2.Services;

namespace T2.Exstension
{
    public static class ServiceExstension
    {
        public static void AddServiceExstension(this IServiceCollection services)
        {
            services.AddTransient<IEntityService, EntityService>();

        }
    }
}
