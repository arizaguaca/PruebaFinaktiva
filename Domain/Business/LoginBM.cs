using Infrastructure.DTO;
using Infrastructure.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Domain.Business
{

   public interface ILoginBM
    {
        Response Login(Login login);
    }

    public class LoginBM : ILoginBM
    {
        public IConfiguration _configuration;
        public IUserBM _userBM;

        public LoginBM(IConfiguration configuration, IUserBM userBM)
        {
            _configuration = configuration;
            _userBM = userBM;
        }

        public Response Login(Login login)
        {
            Response response = new Response();
            UsersModel user = _userBM.AuthenticateUser(login);
            if (user != null)
            {
                response.IdUser = user.idUser;
                response.Token = GenerateJSONWebToken(user);
            }


            return response;
        }

        private string GenerateJSONWebToken(UsersModel userInfo)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("role", userInfo.idRol.ToString()) }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);


        }

       
    }
}
