using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiCore.BL.Services;
using WebApiCore.Dal.Extension;

namespace WebApiCore.BL.Extension
{
    public static class BLExtension
    {
        public static void AddBLServices( this IServiceCollection services, IConfiguration configuration )
        {
            services.AddScoped<IUserService, UserService>( );
            services.AddDalServices(configuration);
        }
    }
}
