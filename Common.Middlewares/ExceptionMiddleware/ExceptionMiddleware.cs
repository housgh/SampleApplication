using Common.Middlewares.ExceptionMiddleware.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Middlewares.ExceptionMiddleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private async static Task HandleException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;

            if (exception.GetType().IsSubclassOf(typeof(CustomException)))
            {
                context.Response.StatusCode = 400;
            }

            await context.Response.WriteAsync(new ExceptionResponse
            {
                ErrorCode = exception.GetType().Name,
                ErrorDescription = exception.Message
            }.ToString());
        }
    }
}
