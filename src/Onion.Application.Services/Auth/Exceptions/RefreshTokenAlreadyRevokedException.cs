﻿using Onion.Application.DataAccess.BaseExceptions;

namespace Onion.Application.Services.Auth.Exceptions;

public class RefreshTokenAlreadyRevokedException : BadRequestException
{
    private const string MESSAGE_KEY = "RefreshTokenAlreadyRevoked";

    public RefreshTokenAlreadyRevokedException() : base(MESSAGE_KEY)
    {
    }
}
