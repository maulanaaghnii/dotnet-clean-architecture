using System.Text;

namespace CleanArchitecture.WebAPI.Extensions;

public static class AuthExtensions
{
    public static void ConfigureAuth(this IServiceCollection services)
    {
        var key = Encoding.ASCII.GetBytes("ThisPassword");

        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.Authen
        }


        );

        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });
    }
}