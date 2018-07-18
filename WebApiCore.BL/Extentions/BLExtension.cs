using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiCore.BL.Services;
using WebApiCore.Dal.Extension;
using WebApiCore.BL.IServices;
using FluentValidation;
using WebApiCore.BL.Models;
using WebApiCore.BL.Validators;
using AutoMapper;

namespace WebApiCore.BL.Extentions
{
    public static class BLExtension
    {
        public static void AddBLServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddDalServices(configuration);
            services.AddScoped<IValidator<UserDataDto>, UserDataDtoValidator>();
            services.AddAutoMapper();
        }
    }
}
