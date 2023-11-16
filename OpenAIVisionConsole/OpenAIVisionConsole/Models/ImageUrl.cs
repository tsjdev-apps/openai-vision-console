using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents an image URL.
/// </summary>
/// <param name="Url"> The URL of the image. </param>
/// <param name="Detail"> The detail of the image. </param>
internal record ImageUrl(
    [property: JsonPropertyName("url")] string Url,
    [property: JsonPropertyName("detail")] string? Detail = "low");
