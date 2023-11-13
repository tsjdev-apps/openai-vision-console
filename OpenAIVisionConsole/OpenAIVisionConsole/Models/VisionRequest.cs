﻿using System.Text.Json.Serialization;

namespace OpenAIVisionConsole.Models;


/// <summary>
///     Represents a request for the vision API.
/// </summary>
/// <param name="Messages">     Indicates the messages to control the 
///     "reading" of the image. </param>
internal record VisionRequest(
    [property: JsonPropertyName("messages")] IEnumerable<ChatMessage>? Messages)
{
    /// <summary>
    ///     Indicates the model which will be used
    ///     to "read" the image.
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; } = "gpt-4-vision-preview";

    /// <summary>
    ///     Indicates the maximum of tokens to be 
    ///     used for "reading" the images.
    /// </summary>
    [JsonPropertyName("max_tokens")]
    public int MaxTokens { get; set; } = 300;
}
