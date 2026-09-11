using System.Text.Json.Serialization;

namespace Garmin.Connect.Models;

public record GarminUpdateActivity
{
    [JsonPropertyName("activityId")]
    public long ActivityId { get; init; }

    [JsonPropertyName("activityName")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ActivityName { get; init; }

    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; init; }

    [JsonPropertyName("activityTypeDTO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ActivityType ActivityType { get; init; }

    [JsonPropertyName("accessControlRuleDTO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AccessControlRuleDto AccessControlRuleDto { get; init; }
}