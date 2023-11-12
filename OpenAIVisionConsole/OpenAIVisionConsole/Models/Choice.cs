using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents a choice in a conversation.
/// </summary>
internal class Choice
{
    /// <summary>
    ///     The message associated with the choice.
    /// </summary>
    [JsonPropertyName("message")]
    public Message? Message { get; set; }

    /// <summary>
    ///     The details of the finish associated with the choice.
    /// </summary>
    [JsonPropertyName("finish_details")]
    public FinishDetailInfo? FinishDetails { get; set; }

    /// <summary>
    ///     The index of the choice.
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }
}
