namespace PassSystemTD.Exceptions;

public class InvalidTokenException(string message): Exception(message)
{
}
public class BadRequestException(string message): Exception(message)
{
}