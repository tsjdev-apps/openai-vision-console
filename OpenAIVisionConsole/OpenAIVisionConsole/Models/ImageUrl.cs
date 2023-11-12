using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents an image URL.
/// </summary>
internal class ImageUrl
{
    /// <summary>
    ///     The URL of the image.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    ///     The detail of the image.
    /// </summary>
    [JsonPropertyName("detail")]
    public string? Detail { get; } = "low";
}
