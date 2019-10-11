using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace MoneyDiary.Web.Middlewares
{
  public class ExceptionHandlerMiddleware
  {
    private const string internalServerError = "Internal Server Error";
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
      _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
      try
      {
        await _next(context);
      }
      catch (Exception ex)
      {
        //logging

        context.Response.Clear();
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "application/json";
        string response = JsonConvert.SerializeObject(new {
          StatusCode = context.Response.StatusCode,
          Message = internalServerError
        });
        await context.Response.WriteAsync(response);
      }
    }
  }
}
