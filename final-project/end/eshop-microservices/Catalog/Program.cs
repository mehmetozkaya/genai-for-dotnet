using Microsoft.Extensions.AI;
using OllamaSharp;
using OpenAI;
using System.ClientModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceDefaults();

builder.AddNpgsqlDbContext<CatalogDbContext>(connectionName: "catalogdb");

builder.Services.AddScoped<ProductAIService>();
builder.Services.AddScoped<ProductService>();
// Add AI Chat Client
var endpoint = builder.Configuration["AI:Endpoint"] ?? throw new InvalidOperationException("Missing configuration: AI:Endpoint.");
var apiKey = builder.Configuration["AI:ApiKey"] ?? throw new InvalidOperationException("Missing configuration: AI:ApiKey.");
var chatModel = builder.Configuration["AI:ChatModel"] ?? throw new InvalidOperationException("Missing configuration: AI:ChatModel.");
var embeddingModel = builder.Configuration["AI:EmbeddingModel"] ?? throw new InvalidOperationException("Missing configuration: AI:EmbeddingModel.");


var chatClient = new OllamaApiClient(endpoint, chatModel);
builder.Services.AddScoped<EmbeddingService>();
builder.Services.AddScoped<ProductAIService>();


builder.Services.AddChatClient(chatClient);

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
