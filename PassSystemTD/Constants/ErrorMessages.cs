namespace PassSystemTD.Constants;

public class ErrorMessages
{
    public const string RequiredField = "Field is required";
    
    //Account
    public const string ProfileNotExistsError = "Profile is not exist";
    
    public const string EmailLengthError = "Minimum length of email = 1";
    public const string EmailNotValid = "Email is invalid";
    public const string EmailValidError = "Email is invalid";
    
    public const string NameLengthError = "Minimum length of name = 1";
    
    public const string PasswordLengthError = "Minimum length of password = 6 and maximummum length of password = 32";
    public const string PasswordNotValid = "Password must include one or more numbers";
    public const string PasswordInvalidError = "Invalid password";
    
    public const string InvalidBirthdateError = "User must be over 16 years old";

    
    //Token 
    public const string UnauthorizedError = "Unauthorized";
    public const string TokenError = "Token is required";
    public const string TokenLengthError = "Minimum length of token = 1";
    
    //Forbidden errors
    public const string AccessDeniedAdminError = "You must be admin";
    public const string AccessDeniedAdminDeanError = "You must be admin or dean";
    public const string AccessDeniedStudentError = "You must be student";
    
    //Not found errors
    public const string NotFoundUserError = "User not found";
    public const string NotFoundRoleError = "Role not found";
    
    //Bad request errors
    public const string InvalidPageCountOrPageSizeError = "Page count and page size must be greater than 0";
    
    //Conflict errors
    public const string ConflictEmailError = "Email is already registered";

}