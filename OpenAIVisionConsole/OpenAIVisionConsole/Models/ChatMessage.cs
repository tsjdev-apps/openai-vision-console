using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents a chat message.
/// </summary>
internal class ChatMessage
{
    /// <summary>
    ///     The role of the chat message.
    /// </summary>
    [JsonPropertyName("role")]
    public string Role { get; } = "user";

    /// <summary>
    ///     The content of the chat message.
    /// </summary>
    [JsonPropertyName("content")]
    public required IEnumerable<MessageContent> Content { get; set; }
}
