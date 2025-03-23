using System.Text.Json.Serialization;
namespace PassSystemTD.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Gender
{
    Male,
    Female
}
