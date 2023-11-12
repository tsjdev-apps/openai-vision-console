using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents a request for the vision API.
/// </summary>
internal class VisionRequest
{
    /// <summary>
    ///     Indicates the model which will be used
    ///     to "read" the image.
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; } = "gpt-4-vision-preview";

    /// <summary>
    ///     Indicates the messages to control the 
    ///     "reading" of the image.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<ChatMessage> Messages { get; set; } = new List<ChatMessage>();

    /// <summary>
    ///     Indicates the maximum of tokens to be 
    ///     used for "reading" the images.
    /// </summary>
    [JsonPropertyName("max_tokens")]
    public int MaxTokens { get; set; } = 300;
}
