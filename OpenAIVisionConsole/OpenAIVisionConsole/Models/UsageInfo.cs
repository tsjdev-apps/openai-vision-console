using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents usage information for 
///     a conversation.
/// </summary>
/// <param name="PromptTokens"> The number of tokens used for prompts. </param>
/// <param name="CompletionTokens"> The number of tokens used for completions. </param>
/// <param name="TotalTokens"> The total number of tokens used. </param>
public record UsageInfo(
    [property: JsonPropertyName("prompt_tokens")] int PromptTokens,
    [property: JsonPropertyName("completion_tokens")] int CompletionTokens,
    [property: JsonPropertyName("total_tokens")] int TotalTokens);
