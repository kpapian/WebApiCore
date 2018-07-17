using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiCore.Dal.Extensions;
using WebApiCore.BL.Services;

namespace WebApiCore.BL.Extensions
{
    public static class BLExtension
    {
        public static void AddBLServices( this IServiceCollection services, IConfiguration configuration )
        {
            services.AddScoped<IUserService, UserService>();
            services.AddDalServices(configuration);
        }
    }
}
