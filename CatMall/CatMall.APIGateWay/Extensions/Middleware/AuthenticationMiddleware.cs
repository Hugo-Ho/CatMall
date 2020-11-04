using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMall.APIGateWay.OpenApi.Extensions.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            //get request rount
            var a =httpContext.Request;
            await _next(httpContext);
        }
    }
}
