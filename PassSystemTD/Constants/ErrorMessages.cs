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
    
    public const string GroupLengthError = "Length of group's number must be 6";
    public const string GroupNotValid = "Group number doesn't exist";
    public const string GroupNumberRequired = "Group number is required for students";
    public const string GroupNumberError = "Only students have group number";

    
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
    public const string NotFoundPassError = "Pass not found";
    public const string NotFoundRoleError = "Role not found";
    
    //Bad request errors
    public const string InvalidPageCountOrPageSizeError = "Page count and page size must be greater than 0";
    public const string PassNotInQueueError = "This pass is not in queue. Status cannot be changed";
    public const string PassAnotherUserError  = "You can't change pass another user";
    public const string PassIsNotAccepted = "This pass has not yet been accepted";
    public const string StartDateError = "Start time of the pass can not be grater than End time ";
    
    //Conflict errors
    public const string ConflictEmailError = "Email is already registered";
    
    //Cloud errors
    public  const string FailedLoadFileError = "Failed to load file. Please try again.";
}