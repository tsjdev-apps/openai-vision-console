using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a choice in a conversation.
/// </summary>
/// <param name="Message"> The message associated with the choice. </param>
/// <param name="FinishDetails"> The details of the finish associated with the choice. </param>
/// <param name="Index"> The index of the choice. </param>
internal record Choice(
    [property: JsonPropertyName("message")] Message? Message, 
    [property: JsonPropertyName("finish_details")] FinishDetailInfo? FinishDetails, 
    [property: JsonPropertyName("index")] int Index);
