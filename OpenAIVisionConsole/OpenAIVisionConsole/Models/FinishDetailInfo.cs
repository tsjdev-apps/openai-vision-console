using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents the details of a finish 
///     associated with a choice.
/// </summary>
/// <param name="Type"> The type of finish. </param>
/// <param name="Message"> The message associated with the finish. </param>
/// <param name="NextChoice"> The details of the next choice. </param>
internal record FinishDetailInfo(
    [property: JsonPropertyName("type")] string? Type, 
    [property: JsonPropertyName("message")] Message? Message, 
    [property: JsonPropertyName("next_choice")] Choice? NextChoice);
