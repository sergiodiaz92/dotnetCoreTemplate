using Microsoft.OpenApi.Models;

namespace BlogApp.API
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ConfigureSwaggerUI(this IServiceCollection services)
        {
            var contact = new OpenApiContact()
            {
                Name = "Sergio Diaz",
                Email = "sergio.d.diaz@outlook.com",
                Url = new Uri("https://github.com/sergiodiaz92")
            };

            var license = new OpenApiLicense()
            {
                Name = "Blog App",
                Url = new Uri("https://www.blogapp.com")
            };

            var info = new OpenApiInfo()
            {
                Version = "v1",
                Title = "Blog App",
                Description = "API which handle a Blog App",
                TermsOfService = new Uri("https://www.blogapp.com/terms/"),
                Contact = contact,
                License = license
            };

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("BlogApp", info);
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = @"JWT Authorization header using the Bearer scheme. 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }},
                        new List<string>()
                    }
                });
            });

            return services;
        }
    }
}
