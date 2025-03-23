using System.Text.Json.Serialization;

namespace PassSystemTD.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PassStatus
{
    InQueue,
    Accepted,
    Declined
}