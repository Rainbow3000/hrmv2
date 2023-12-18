﻿
using Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filter.Jwt
{
    public class AdminTokenFilter : IActionFilter
    {
        private readonly IConfiguration _configuration;

        public AdminTokenFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string token = new JwtValidateHelper(_configuration).TokenIsExist(context);
            if (token == null)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Result = new ObjectResult(new
                {
                    Code = StatusCodes.Status401Unauthorized,
                    Message = "Token không tồn tại"
                });
                return;
            }
            string role = new JwtValidateHelper(_configuration).ValidateToken(context, token);
            if (role != "ADMIN")
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                context.Result = new ObjectResult(new
                {
                    Code = StatusCodes.Status403Forbidden,
                    Message = "Tài khoản không có quyền"
                });
            }
        }
    }
}