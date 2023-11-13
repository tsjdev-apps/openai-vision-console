using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents an image URL.
/// </summary>
/// <param name="Url"> The URL of the image. </param>
internal record ImageUrl(
    [property: JsonPropertyName("url")] string Url)
{
    /// <summary>
    ///     The detail of the image.
    /// </summary>
    [JsonPropertyName("detail")]
    public string? Detail { get; } = "low";
}
