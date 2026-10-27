using System.Net;

namespace Unova.App.Responses;

public record MiddlewareExceptionResponse(HttpStatusCode StatusCode, string Message);