using PazaryeriTrello.Interfaces;
using PazaryeriTrello.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using PazaryeriTrello.Helpers;
using Microsoft.Extensions.Options;
using PazaryeriTrello.Models;
using PazaryeriTrello.Models.Data;
using AutoMapper;

namespace PazaryeriTrello.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppSettings _appSettings;
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public AccountService(IOptions<AppSettings> appSettings, DataContext dataContext, IMapper mapper)
        {
            _appSettings = appSettings.Value;
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public LoginResponse Login(LoginRequest request)
        {
            LoginResponse response = new LoginResponse { IsSuccess = true };

            var isUserExists = _dataContext.Users.Any(x => x.Name == request.UserName && x.Password == request.PassWord);

            if (isUserExists)
            {
                var user = _dataContext.Users.First(x => x.Name == request.UserName && x.Password == request.PassWord);
                var userDTO = _mapper.Map<UserDTO>(user);

                response.Token = GenerateJwtToken(userDTO);
                response.UserId = user.Id;
                response.UserName = user.Name;
            }
            else
                response.IsSuccess = false;

            return response;
        }

        private string GenerateJwtToken(UserDTO user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                        new[] {
                            new Claim("id", user.Id.ToString()),
                            new Claim("name", user.Name)
                        }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
