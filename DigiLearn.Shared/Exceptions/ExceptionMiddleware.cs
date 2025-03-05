using DigiLearn.Shared.Abstraction.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
namespace DigiLearn.Shared.Exceptions;

public class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleException(context, ex);
        }
    }

    private static Task HandleException(HttpContext context, Exception ex)
    {
        HttpStatusCode code = HttpStatusCode.InternalServerError;

        if (ex is UserManagementException)
        {
            code = HttpStatusCode.BadRequest;
        }

        else if (ex is CourseManagementException)
        {
            code = HttpStatusCode.BadRequest;
        }

        else if (ex is PaymentManagementException)
        {
            code = HttpStatusCode.BadRequest;
        }

        var errorCode = ToUnderscoreCase(ex.GetType().Name.Replace("Exception", string.Empty));

        var json = JsonSerializer.Serialize(new { ErrorCode = errorCode, ex.Message });

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(json);
    }

    public static string ToUnderscoreCase(string value)
    {
        return string.Concat((value ?? string.Empty).Select((x, i) => i > 0 && char.IsUpper(x) && !char.IsUpper(value[i - 1]) ? $"_{x}" : x.ToString())).ToLower();
    }

}
