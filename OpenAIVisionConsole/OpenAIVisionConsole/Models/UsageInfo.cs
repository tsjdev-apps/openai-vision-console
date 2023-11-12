using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;

/// <summary>
///     Represents usage information for 
///     a conversation.
/// </summary>
public class UsageInfo
{
    /// <summary>
    ///     The number of tokens used for prompts.
    /// </summary>
    [JsonPropertyName("prompt_tokens")]
    public int PromptTokens { get; set; }

    /// <summary>
    ///     The number of tokens used for completions.
    /// </summary>
    [JsonPropertyName("completion_tokens")]
    public int CompletionTokens { get; set; }

    /// <summary>
    ///     The total number of tokens used.
    /// </summary>
    [JsonPropertyName("total_tokens")]
    public int TotalTokens { get; set; }
}
