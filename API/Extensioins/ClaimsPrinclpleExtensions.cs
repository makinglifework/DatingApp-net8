using System.Security.Claims;

namespace API.Extensioins;

public static class ClaimsPrinclpleExtensions
{
    public static string GetUserName(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.Name)
            ?? throw new Exception("Cannot get username from token");
        return username;
    } 

     public static int GetUserId(this ClaimsPrincipal user)
    {
        var userId = int.Parse(user.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? throw new Exception("Cannot get username from token"));
        return userId;
    } 
    
    
}
