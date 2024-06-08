﻿using Auth.Backend.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

// TODO: 1. Implementar validação a nível de banco
//       2. Adicionar as variáveis de ambiente no Github
//       3. Adicionar expirationToken (fazer retry do token)
//       4. Não deixar gerar dois tokens para o mesmo usuário

namespace Auth.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth(IConfiguration configuration) : ControllerBase
    {
        private readonly IConfiguration _configuration = configuration;

        /// <summary>
        /// Rota para gerar um token válido para o usuário
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(typeof(LoginRequest), StatusCodes.Status200OK)]
        public IActionResult LoginUser(LoginRequest loginRequest)
        {
            if(loginRequest == null || (!loginRequest.UserName.Equals("victorluizskt") || !loginRequest.Password.Equals("123456")))
            {
                return BadRequest("User or password invalid.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Sectoken = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Issuer"],
                null,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return Ok(token);
        }
    }
}
