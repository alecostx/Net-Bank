using Microsoft.EntityFrameworkCore;
using NetBank.Domain.Interfaces.Repository;
using NetBank.Domain.Interfaces.Service;
using NetBank.Domain.Services;
using NetBank.Infrastructure.Context;
using NetBank.Infrastructure.Context.Repository;

namespace NetBank.API.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<DbContext, DataContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
