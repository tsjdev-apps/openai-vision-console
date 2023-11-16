using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a chat message.
/// </summary>
/// <param name="Content"> The content of the chat message. </param>
/// <param name="Role"> The role of the chat message.</param>
internal record ChatMessage(
    [property: JsonPropertyName("content")] IEnumerable<MessageContent> Content,
    [property: JsonPropertyName("role")] string Role = "user");
