using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents a message in a conversation.
/// </summary>
internal class Message
{
    /// <summary>
    ///     The role of the message.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    ///     The content of the message.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
