using Onion.Application.DataAccess.Database.Entities.Fields;

namespace Onion.Application.Services.Auth.Models;

public class AuthRes
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public UserRole Role { get; set; }

}
