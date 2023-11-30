using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using TiendaCodeFirst.Helpers;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private HelperOAuthToken helper;
        private IRepositoryClientesTienda repo;
        public AuthController(HelperOAuthToken helper, IRepositoryClientesTienda repo)
        {
            this.helper = helper;
            this.repo = repo;
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginClienteModel model)
        {
            Cliente cliente = await this.repo.ExisteClienteAsync(model);
            if (cliente == null)
            {
                return Unauthorized();
            }
            else
            {
                SigningCredentials credentials = new SigningCredentials(this.helper.GetTokenKey(), SecurityAlgorithms.HmacSha256);
                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: this.helper.Issuer,
                    audience: this.helper.Audience,
                    signingCredentials: credentials,
                    expires: DateTime.UtcNow.AddMinutes(20),
                    notBefore: DateTime.UtcNow
                    );
                return
                    Ok(
                        new
                        {
                            response = new JwtSecurityTokenHandler().WriteToken(token)
                        }
                        );
            }
        }
    }
}
