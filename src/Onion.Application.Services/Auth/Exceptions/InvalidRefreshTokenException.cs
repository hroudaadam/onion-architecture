using Onion.Core.Exceptions;

namespace Onion.Application.Services.Auth.Exceptions;

public class InvalidRefreshTokenException : BadRequestException
{
    private const string MESSAGE_KEY = "InvalidRefreshToken";
    public InvalidRefreshTokenException() : base(MESSAGE_KEY)
    {
    }
}
