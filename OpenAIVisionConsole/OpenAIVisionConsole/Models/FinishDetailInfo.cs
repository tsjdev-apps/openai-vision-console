using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents the details of a finish 
///     associated with a choice.
/// </summary>
internal class FinishDetailInfo
{
    /// <summary>
    ///     The type of finish.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    ///     The message associated with the finish.
    /// </summary>
    [JsonPropertyName("message")]
    public Message? Message { get; set; }

    /// <summary>
    ///     The details of the next choice.
    /// </summary>
    [JsonPropertyName("next_choice")]
    public Choice? NextChoice { get; set; }
}
