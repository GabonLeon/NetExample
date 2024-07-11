
namespace NetExample.Authorization;

using NetExample.Services;
public class JwtMiddleware
{
    private readonly RequestDelegate _next;

    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        if (token != null)
        {
            var userId = jwtUtils.ValidateToken(token);
            if (userId != null)
            {
                context.Items["UserId"] = userId;
                context.Items["User"] = userService.GetById(userId.Value);
            }
        }

        await _next(context);
    }
}