using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents a response from the OpenAI Vision API.
/// </summary>
internal class VisionResponse
{
    /// <summary>
    ///     The ID of the response.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    ///     The object type of the response.
    /// </summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>
    ///     The timestamp of when the response was created.
    /// </summary>
    [JsonPropertyName("created")]
    public int Created { get; set; }

    /// <summary>
    ///     The model used for the response.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    ///     The usage information for the response.
    /// </summary>
    [JsonPropertyName("usage")]
    public UsageInfo? Usage { get; set; }

    /// <summary>
    ///     The choices associated with the response.
    /// </summary>
    [JsonPropertyName("choices")]
    public IEnumerable<Choice> Choices { get; set; } = new List<Choice>();
}
