using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a response from the OpenAI Vision API.
/// </summary>
/// <param name="Id"> The ID of the response. </param>
/// <param name="Object"> The object type of the response. </param>
/// <param name="Created"> The timestamp of when the response was created. </param>
/// <param name="Model"> The model used for the response. </param>
/// <param name="Usage"> The usage information for the response. </param>
/// <param name="Choices"> The choices associated with the response. </param>
internal record VisionResponse(
    [property: JsonPropertyName("id")] string? Id,
    [property: JsonPropertyName("object")] string? Object,
    [property: JsonPropertyName("created")] int Created,
    [property: JsonPropertyName("model")] string? Model,
    [property: JsonPropertyName("usage")] UsageInfo? Usage,
    [property: JsonPropertyName("choices")] IEnumerable<Choice> Choices);
