using System.Text.Json.Serialization;

namespace PassSystemTD.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SortType
{
    CreatedAsc,
    CreatedDesc
}