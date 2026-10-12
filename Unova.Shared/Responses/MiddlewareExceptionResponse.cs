using System.Net;

namespace Unova.Shared.Responses;
public record MiddlewareExceptionResponse(HttpStatusCode StatusCode, string Message);