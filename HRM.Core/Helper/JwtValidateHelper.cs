using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    public class JwtValidateHelper
    {
        private readonly IConfiguration _configuration;
        private static string? accountIdFromToken;
        public JwtValidateHelper(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        public string TokenIsExist(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;
            if (!request.Headers.ContainsKey("Authorization") || string.IsNullOrWhiteSpace(request.Headers["Authorization"].ToString()))
            {
                return null; 
            }
            return request.Headers["Authorization"].ToString().Split(" ")[1]; 
        }

        public bool ValidateAuthUser(string accountId)
        {
            if(accountIdFromToken?.Trim() == accountId.Trim())
            {
                return true;
            }
            return false; 
        }

        public dynamic ValidateToken(ActionExecutingContext context,string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters
                {

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ClockSkew = TimeSpan.Zero
                };

                handler.ValidateToken(token,tokenValidationParameters, out SecurityToken validatedToken);
                var jwtToken = (JwtSecurityToken)validatedToken;
               
                if (jwtToken != null)
                {
                    string TokenExpriredTime = jwtToken.Claims.First(x => x.Type == "exp").Value;
                    var TimeNow = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    if (TokenExpriredTime != null)
                    {
                        long tokenTime;
                        long.TryParse(TokenExpriredTime, out tokenTime);
                        if (tokenTime < TimeNow)
                        {
                            context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                            context.Result = new ObjectResult(new
                            {
                                Code = StatusCodes.Status401Unauthorized,
                                Message = "Token đã hết hạn"
                            });
                        }

                    }
                    string role = jwtToken.Claims.First(x => x.Type == "role").Value;      
                    string accountId = jwtToken.Claims.First(x => x.Type == "accountId").Value.ToString();
                    accountIdFromToken = accountId; 
                    return role; 
                  
                }

               

            }
            catch(SecurityTokenInvalidSignatureException ex)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Result = new ObjectResult(new
                {
                    Code = StatusCodes.Status401Unauthorized,
                    Message = "Token không hợp lệ"
                });
            }

            return null; 
                      
        }
    }
}
