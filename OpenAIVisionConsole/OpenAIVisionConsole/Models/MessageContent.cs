using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents the content of a 
///     message in a conversation.
/// </summary>
/// <param name="Type"> The type of the message content. </param>
/// <param name="Text"> The text content of the message. </param>
/// <param name="ImageUrl"> The image URL associated with the message. </param>
internal record MessageContent(
    [property: JsonPropertyName("type")] string? Type, 
    [property: JsonPropertyName("text")] string? Text, 
    [property: JsonPropertyName("image_url")] ImageUrl? ImageUrl);
