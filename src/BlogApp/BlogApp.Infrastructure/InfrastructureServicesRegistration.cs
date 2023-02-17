using BlogApp.Application.Contracts.Data;
using BlogApp.Application.Contracts.Identity;
using BlogApp.Infrastructure.Data;
using BlogApp.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BlogApp.Application.Models.Identity;

namespace BlogApp.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddDbContext<BlogContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BlogAppConnection"),
                    b => b.MigrationsAssembly(typeof(BlogContext).Assembly.FullName)));

            services.AddScoped<IBlogContext>(provider => provider.GetService<BlogContext>());

            services.AddIdentity<ApplicationUser,IdentityRole>()
                .AddEntityFrameworkStores<BlogContext>();

            services.AddTransient<IIdentityService, IdentityService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            return services;
        }
    }
}
