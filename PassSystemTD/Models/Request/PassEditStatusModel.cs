using System.ComponentModel.DataAnnotations;
using PassSystemTD.Constants;
using PassSystemTD.Models.Enums;

namespace PassSystemTD.Models.Request;

public class PassEditStatusModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredField)]
    [EnumDataType(typeof(PassStatus))]
    public PassStatus Status { get; set; }
}