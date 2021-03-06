using Onion.Core.Exceptions;

namespace Onion.Application.Services.Auth.Exceptions;

public class RefreshTokenNotFoundException : NotFoundException
{
    private const string MESSAGE_KEY = "RefreshTokenNotFound";

    public RefreshTokenNotFoundException() : base(MESSAGE_KEY)
    {
    }
}
