using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a chat message.
/// </summary>
/// <param name="Content">     The content of the chat message. </param>
internal record ChatMessage(
    [property: JsonPropertyName("content")] IEnumerable<MessageContent> Content)
{
    /// <summary>
    ///     The role of the chat message.
    /// </summary>
    [JsonPropertyName("role")]
    public string Role { get; } = "user";
}
