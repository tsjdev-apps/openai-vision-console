using OpenAIVisionConsole.Models;
using Spectre.Console;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

bool isRunning = true;

string completionsEndpoint = "https://api.openai.com/v1/chat/completions";
JsonSerializerOptions jsonOptions = new()
{
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
};

while (isRunning)
{
    AnsiConsole.Clear();

    // Create header
    CreateHeader();

    // Get Token
    string token = GetToken();

    AnsiConsole.Clear();
    CreateHeader();

    // Get file path
    string filePath = GetFilePath();

    AnsiConsole.Clear();
    CreateHeader();

    // LOGIC
    await AnsiConsole.Status()
        .StartAsync("Analyzing image...", async ctx =>
        {
            try
            {
                byte[] imageBytes = await File.ReadAllBytesAsync(filePath);
                string imageAsBase64String = Convert.ToBase64String(imageBytes);
                string fileExtension = Path.GetExtension(filePath);

                HttpClient client = new();

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                VisionRequest visionRequest = new()
                {
                    Messages = new List<ChatMessage>
                    {
                        new ChatMessage
                        {
                            Content = new List<MessageContent>
                            {
                                new MessageContent
                                {
                                    Type = "text",
                                    Text = "What's in this image?"
                                },
                                new MessageContent
                                {
                                    Type = "image_url",
                                    ImageUrl = new ImageUrl
                                    {
                                        Url = $"data:image/{fileExtension};base64,{imageAsBase64String}"
                                    }
                                }
                            }
                        }
                    }
                };

                string json = JsonSerializer.Serialize(visionRequest, jsonOptions);

                HttpResponseMessage response = await client.PostAsync(completionsEndpoint, new StringContent(json, Encoding.UTF8, "application/json"));
                VisionResponse? visionResponse = await response.Content.ReadFromJsonAsync<VisionResponse>();
                string? content = visionResponse?.Choices?.FirstOrDefault()?.Message?.Content;

                if (!string.IsNullOrEmpty(content))
                {
                    AnsiConsole.MarkupLine($"Here is a description of your provided image: [yellow]{content}[/]");
                    AnsiConsole.WriteLine();
                }
                else
                {
                    AnsiConsole.MarkupLine("Unfortunately there is no content available to display.");
                }
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"Something went wrong: [red]{ex.Message}[/]");
            }
        });

    AnsiConsole.WriteLine();
    isRunning = AnsiConsole.Confirm("Do you want to get a desription of another image?", false);
}


/// <summary>
///     Creates the header for the console application.
/// </summary>
static void CreateHeader()
{
    // Create a grid for the header text
    Grid grid = new();
    grid.AddColumn();
    grid.AddRow(new FigletText("GPT-4 Vision").Centered().Color(Color.Red));
    grid.AddRow(Align.Center(new Panel("[red]Sample by Thomas Sebastian Jensen ([link]https://www.tsjdev-apps.de[/])[/]")));

    // Write the grid to the console
    AnsiConsole.Write(grid);
    AnsiConsole.WriteLine();
}

/// <summary>
///     Prompts the user for their OpenAI API key.
/// </summary>
/// <returns>The user's OpenAI API key.</returns>
static string GetToken()
    => AnsiConsole.Prompt(
        new TextPrompt<string>("Please insert your [yellow]OpenAI API key[/]:")
        .PromptStyle("white")
        .ValidationErrorMessage("[red]Invalid prompt[/]")
        .Validate(prompt =>
        {
            if (prompt.Length < 3)
            {
                return ValidationResult.Error("[red]API key too short[/]");
            }

            if (prompt.Length > 200)
            {
                return ValidationResult.Error("[red]API key too long[/]");
            }

            return ValidationResult.Success();
        }));

/// <summary>
///     Prompts the user for the file path represents the image file.
/// </summary>
/// <returns>The user's selected file path for the image file.</returns>
static string GetFilePath()
    => AnsiConsole.Prompt(
        new TextPrompt<string>("Please insert the [yellow]path[/] to the image file:")
        .PromptStyle("white")
        .ValidationErrorMessage("[red]Invalid input[/]")
        .Validate(prompt =>
        {
            if (prompt.Length < 3)
            {
                return ValidationResult.Error("[red]File path too short[/]");
            }

            if (prompt.Length > 256)
            {
                return ValidationResult.Error("[red]File path too long[/]");
            }

            return ValidationResult.Success();
        }));