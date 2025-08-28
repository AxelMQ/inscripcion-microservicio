using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Controllers.Sync
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IConfiguration _configuration;

    public AuthController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
      // NOTA: Aquí iría tu lógica real de validación de credenciales.
      // Por ahora, usamos una validación simple solo para el ejemplo.
      if (model.Username == "admin" && model.Password == "password123")
      {
        var token = GenerateJwtToken(model.Username);
        return Ok(new { token });
      }

      return Unauthorized("Credenciales inválidas.");
    }

    private string GenerateJwtToken(string username)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var expires = _configuration["Jwt:ExpiresInMinutes"] != null
          ? DateTime.Now.AddMinutes(double.Parse(_configuration["Jwt:ExpiresInMinutes"]!))
          : DateTime.Now.AddMinutes(60); // Valor por defecto de 60 minutos

      var claims = new[]
      {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

      var token = new JwtSecurityToken(
          issuer: _configuration["Jwt:Issuer"],
          audience: _configuration["Jwt:Audience"],
          claims: claims,
          expires: expires,
          signingCredentials: credentials);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }

  public class LoginModel
  {
    public string Username { get; set; }
    public string Password { get; set; }
  }
}