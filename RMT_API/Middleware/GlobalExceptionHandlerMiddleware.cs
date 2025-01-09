namespace RMT_API.Middleware
{
	public class GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
	{
		private readonly RequestDelegate _next = next;
		private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger = logger;

		public async Task InvokeAsync(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (Exception ex)
			{
				// Log the exception
				_logger.LogError(ex, "Unhandled exception occurred.");

				// Set response status code and message
				httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
				httpContext.Response.ContentType = "application/json";

				// Return a custom error response
				var errorResponse = new
				{
					Message = "An unexpected error occurred.",
					Detail = ex.Message
				};

				await httpContext.Response.WriteAsJsonAsync(errorResponse);
			}
		}
	}

}
