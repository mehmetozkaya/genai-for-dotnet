using Microsoft.Extensions.AI;
using OpenAI;
using System.ClientModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceDefaults();

builder.AddNpgsqlDbContext<CatalogDbContext>(connectionName: "catalogdb");

builder.Services.AddScoped<ProductAIService>();
builder.Services.AddScoped<ProductService>();

// Add AI Chat Client
var credential = new ApiKeyCredential(builder.Configuration["GitHubModels:Token"] ?? throw new InvalidOperationException("Missing configuration: GitHubModels:Token."));
var options = new OpenAIClientOptions()
{
    Endpoint = new Uri("https://models.github.ai/inference")
};

var openAiClient = new OpenAIClient(credential, options);

var chatClient =
    openAiClient.GetChatClient("openai/gpt-5-mini").AsIChatClient(); // if not worked use: gpt-4o-mini

var embeddingGenerator =
    openAiClient.GetEmbeddingClient("openai/text-embedding-3-small").AsIEmbeddingGenerator();

builder.Services.AddChatClient(chatClient);
builder.Services.AddEmbeddingGenerator(embeddingGenerator);

// Add Vector DB Search Operations
builder.AddQdrantClient("vectordb");
builder.Services.AddQdrantCollection<ulong, ProductVector>("product-vectors");

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapDefaultEndpoints();

app.UseHttpsRedirection();

app.UseMigration();

app.MapProductEndpoints();

app.Run();
