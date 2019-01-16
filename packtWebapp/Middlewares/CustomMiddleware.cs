using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static packtWebapp.Startup;

namespace packtWebapp.Middlewares
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine($" ---> Resquet asked for {httpContext.Request.Path}");
            
            // Call the next middleware delegate in the pipeline
            await _next.Invoke(httpContext);
        }
    }
}
