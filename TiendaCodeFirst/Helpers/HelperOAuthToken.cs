using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TiendaCodeFirst.Helpers
{
    public class HelperOAuthToken
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }

        public string SecretKey { get; set; }

        public HelperOAuthToken(IConfiguration configuration) {
            this.Issuer = configuration.GetValue<string>("Issuer");
            this.Audience = configuration.GetValue<string>("Audience");
            this.SecretKey = configuration.GetValue<string>("SecretKey");
        }

        public SymmetricSecurityKey GetTokenKey()
        {
            byte[] tokenKey =
                Encoding.UTF8.GetBytes(this.SecretKey);
            return new SymmetricSecurityKey(tokenKey);
        }

        public Action<JwtBearerOptions> GetJwtBearerOptions()
        {
            Action<JwtBearerOptions> options = new Action<JwtBearerOptions>(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = this.Issuer,
                    ValidAudience = this.Audience,
                    IssuerSigningKey = this.GetTokenKey()
                };
            });
            return options;
        }

        public Action<AuthenticationOptions> GetAuthenticationOptions()
        {
            Action<AuthenticationOptions> options = new Action<AuthenticationOptions>(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            });
            return options;
        }
    }
}
