﻿namespace PassSystemTD.Configurations;

public class JwtOptions
{
    public string SecretKey { get; set; }
    public int ExpiresHours { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
}