using System.Security.Claims;

namespace API.Extensioins;

public static class ClaimsPrinclpleExtensions
{
    public static string GetUserName(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.NameIdentifier) 
            ?? throw new Exception("CannotUnloadAppDomainException get username from token");
        return username;
    } 
}
