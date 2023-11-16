using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a request for the vision API.
/// </summary>
/// <param name="Messages"> Indicates the messages to control the 
///     "reading" of the image. </param>
/// <param name="Model"> Indicates the model which will be used
///     to "read" the image. </param>
/// <param name="MaxTokens"> Indicates the maximum of tokens to be 
///     used for "reading" the images. </param>
internal record VisionRequest(
    [property: JsonPropertyName("messages")] IEnumerable<ChatMessage>? Messages,
    [property: JsonPropertyName("model")] string? Model = "gpt-4-vision-preview",
    [property: JsonPropertyName("max_tokens")] int MaxTokens = 300);
