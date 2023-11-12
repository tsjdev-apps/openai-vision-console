using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents the content of a 
///     message in a conversation.
/// </summary>
internal class MessageContent
{
    /// <summary>
    ///     The type of the message content.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    ///     The text content of the message.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; } = null;

    /// <summary>
    ///     The image URL associated with the message.
    /// </summary>
    [JsonPropertyName("image_url")]
    public ImageUrl? ImageUrl { get; set; } = null;
}
