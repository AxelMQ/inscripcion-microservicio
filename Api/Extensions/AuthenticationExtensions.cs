// Extensions/AuthenticationExtensions.cs
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Api.Extensions
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwt = configuration.GetSection("Jwt");
            var key = jwt["Key"];
            if (string.IsNullOrWhiteSpace(key))
                throw new InvalidOperationException("Missing configuration 'Jwt:Key'.");

            var issuer   = jwt["Issuer"];
            var audience = jwt["Audience"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    // En prod, deja true si sirves sobre HTTPS
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),

                        // Valida issuer/audience si los configuraste
                        ValidateIssuer = !string.IsNullOrEmpty(issuer),
                        ValidIssuer    = issuer,

                        ValidateAudience = !string.IsNullOrEmpty(audience),
                        ValidAudience    = audience,

                        ValidateLifetime = true,
                        // evita “gracia” de 5 minutos; expira exacto
                        ClockSkew = TimeSpan.Zero
                    };
                });

            services.AddAuthorization();
            return services;
        }
    }
}
