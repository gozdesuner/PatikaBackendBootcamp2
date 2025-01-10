using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace _14.Week_JWT__Uygulama.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            // Örnek bir kullanıcı doğrulama işlemi (gerçek bir uygulamada veritabanı kontrolü yapılır)
            if (loginDto.Email == "test@example.com" && loginDto.Password == "password")
            {
                var token = GenerateJwtToken(loginDto.Email);
                return Ok(new { Token = token });
            }

            return Unauthorized("Geçersiz kullanıcı adı veya şifre.");
        }

        private string GenerateJwtToken(string email)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
        new Claim(JwtRegisteredClaimNames.Sub, email), // Kullanıcının email adresini ekliyoruz
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // Benzersiz bir token kimliği ekliyoruz
    };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    public class LoginDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
