using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a message in a conversation.
/// </summary>
/// <param name="Role"> The role of the message. </param>
/// <param name="Content"> The content of the message. </param>
internal record Message(
    [property: JsonPropertyName("role")] string? Role, 
    [property: JsonPropertyName("content")] string? Content);
