using API.Controllers.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
