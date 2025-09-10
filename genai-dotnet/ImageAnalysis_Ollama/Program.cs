using Microsoft.Extensions.AI;
using OllamaSharp;

// create a chat client
IChatClient client =
    new OllamaApiClient(new Uri("http://localhost:11434"), "llava");

// user prompts
var promptDescribe = "Describe the image";
var promptAnalyze = "How many red cars are in the picture? and what other car colors are there?";

// prompts
string systemPrompt = "You are a useful assistant that describes images using a direct style.";
var userPrompt = promptAnalyze;

List<ChatMessage> messages =
[
    new ChatMessage(ChatRole.System, systemPrompt),
    new ChatMessage(ChatRole.User, userPrompt),
];

// read the image bytes, create a new image content part and add it to the messages
var imageFileName = "cars.png";
string image = Path.Combine(Directory.GetCurrentDirectory(), "images", imageFileName);

AIContent aic = new DataContent(File.ReadAllBytes(image), "image/png");
var message = new ChatMessage(ChatRole.User, [aic]);
messages.Add(message);

// send the messages to the assistant
var response = await client.GetResponseAsync(messages);
Console.WriteLine($"Prompt: {userPrompt}");
Console.WriteLine($"Image: {imageFileName}");
Console.WriteLine($"Response: {response.Messages[0]}");