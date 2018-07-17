using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiCore.Dal.DataContext;

namespace WebApiCore.Dal.Extension
{
    public static class DalExtension
    {
        public static void AddDalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserContext>(options =>
                                                   options.UseSqlServer(configuration.GetConnectionString("DBConnection")));
        }
    }
}
