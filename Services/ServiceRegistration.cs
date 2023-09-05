using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CommonServiceCore.Models;
using System.Reflection;
using CommonServiceCore.Interfaces;
using CommonServiceCore.Repository;

namespace CommonServiceCore.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services, IConfiguration configuration, string environmentName)
        {
            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            services.AddHttpContextAccessor();

            services.AddDbContext<MasterApprovalContext>(
                opt =>
                {
                    opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                    if (!environmentName.Equals("Production", StringComparison.InvariantCultureIgnoreCase))
                    {
                        opt.EnableSensitiveDataLogging();
                    }
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("*", "*")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            services.AddScoped<ITokenValidationService, TokenValidationServices>();
            services.AddScoped<ITokenValidation, TokenValidation>();

            return services;
        }
    }
}
