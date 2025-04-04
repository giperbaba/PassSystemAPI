﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PassSystemTD.Configurations;
using PassSystemTD.Constants;
using PassSystemTD.Data;
using PassSystemTD.Entities;
using PassSystemTD.Exceptions;
using PassSystemTD.Services.Interfaces;

namespace PassSystemTD.Services.Impls;

public class TokenService(IOptions<JwtOptions> options, DataContext context, JwtSecurityTokenHandler tokenHandler, TokenValidationParameters tokenValidationParameters) : ITokenService

{
    private readonly JwtOptions _options = options.Value;
    public string GenerateToken(User user)
    {

        var claims = new[]
        {
            new Claim(ClaimTypes.Sid, user.Id.ToString())
        };

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _options.Issuer,
            audience: _options.Audience,
            claims: claims,
            signingCredentials: signingCredentials,
            expires: DateTime.UtcNow.AddHours(_options.ExpiresHours));

        var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
    public async Task<bool> IsTokenBanned(string token)
    {
        return await context.BannedTokens.AnyAsync(t => t.Token == token);
    }

    public string GetIdByToken(string token)
    {
        if (!tokenHandler.CanReadToken(token)) throw new InvalidTokenException(ErrorMessages.UnauthorizedError);

        var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

        var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid);
        if (userIdClaim == null)
        {
            Console.WriteLine("SID claim not found. Claims in the token:");
            foreach (var claim in jwtToken.Claims)
            {
                Console.WriteLine($"Type: {claim.Type}, Value: {claim.Value}");
            }
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);
        }
        var userId = userIdClaim.Value;
        if (userId == null) throw new InvalidTokenException(ErrorMessages.UnauthorizedError);

        return userId;
    }

    public string ExtractTokenFromHeader(string authorizationHeader)
    {
        if (string.IsNullOrEmpty(authorizationHeader))
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);

        if (!authorizationHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            throw new InvalidTokenException(ErrorMessages.UnauthorizedError);

        return authorizationHeader.Substring("Bearer ".Length).Trim();
    }
    public bool ValidateToken(string? token)
    {
        try
        {
            tokenHandler.ValidateToken(token, tokenValidationParameters, out _);
            return true;
        }
        catch
        {
            return false;
        }
    }
}