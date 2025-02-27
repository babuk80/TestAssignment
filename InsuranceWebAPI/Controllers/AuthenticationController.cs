using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InsuranceWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		[AllowAnonymous]
		[HttpPost("token")]
		public IActionResult GenerateToken()
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes("3f8e2b7d9a4c6f1e8b2d3c4a5e6f7d8c9b0a1e2d3f4c5b6a7d8e9f0a1b2c3d4");
			var claims = new[]
				{
					new Claim(JwtRegisteredClaimNames.Iss, "https://localhost:7133"),  
					new Claim(JwtRegisteredClaimNames.Aud, "https://localhost:7133"),  
					new Claim(JwtRegisteredClaimNames.Sub, "12345"),  
					new Claim(JwtRegisteredClaimNames.Name, "John Doe"),  
					new Claim(JwtRegisteredClaimNames.Email, "john.doe@example.com"),  
					new Claim(ClaimTypes.Role, "Admin")  
				};
			var claimsIdentity = new ClaimsIdentity(claims);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Expires = DateTime.UtcNow.AddHours(1),
				Subject= claimsIdentity,
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			var tokenString = tokenHandler.WriteToken(token);

			//To validate the token properly genereated
			var validationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = "https://localhost:7133",
				ValidAudience = "https://localhost:7133",
				IssuerSigningKey = new SymmetricSecurityKey(key)
			};

			var principal = tokenHandler.ValidateToken(tokenString, validationParameters, out var validatedToken);

			return Ok(tokenString);
		}
	}
}
