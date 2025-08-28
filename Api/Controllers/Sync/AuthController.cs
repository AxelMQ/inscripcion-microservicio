using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
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
      var key = _configuration["Jwt:Key"]!;
      var creds = new SigningCredentials(
          new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
          SecurityAlgorithms.HmacSha256);

      int minutes = 60;
      _ = int.TryParse(_configuration["Jwt:ExpiresInMinutes"], out minutes);

      var claims = new[]
      {
        new Claim(JwtRegisteredClaimNames.Sub, username),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

      var token = new JwtSecurityToken(
          issuer: _configuration["Jwt:Issuer"],
          audience: _configuration["Jwt:Audience"],
          claims: claims,
          notBefore: DateTime.UtcNow,
          expires: DateTime.UtcNow.AddMinutes(minutes),
          signingCredentials: creds);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }

  public sealed class LoginModel
  {
    [Required] public string Username { get; init; } = string.Empty;
    [Required] public string Password { get; init; } = string.Empty;
  }

}