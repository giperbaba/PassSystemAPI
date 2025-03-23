namespace PassSystemTD.Constants;

public static class RegexConstants
{
    public const string PasswordRegex = @"^(?=.*\d)[A-Za-z\d@$!%*?&]{6,32}$";
    public const string GroupRegex = @"^(0[1-9]|[1-9][0-9])(1[6-9]|2[0-5])(0[1-9]|1[0-9]|20)$";
}