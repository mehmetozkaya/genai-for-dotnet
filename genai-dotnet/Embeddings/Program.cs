using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using OpenAI;
using System.ClientModel;
using System.Numerics.Tensors;

// get credentials from user secrets
IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

var credential = new ApiKeyCredential(config["GitHubModels:Token"] ?? throw new InvalidOperationException("Missing configuration: GitHubModels:Token."));
var options = new OpenAIClientOptions()
{
    Endpoint = new Uri("https://models.github.ai/inference")
};

// create a chat client
IChatClient client =
    new OpenAIClient(credential, options).GetChatClient("openai/gpt-5-mini").AsIChatClient();

// Create an embedding generator (text-embedding-3-small is an example)
IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator =
    new OpenAIClient(credential, options).GetEmbeddingClient("openai/text-embedding-3-small").AsIEmbeddingGenerator();

//// 1: Generate a single embedding
//var embedding = await embeddingGenerator.GenerateVectorAsync("Hello, world!");
//Console.WriteLine($"Embedding dimensions: {embedding.Span.Length}");
//foreach (var value in embedding.Span)
//{
//    Console.Write("{0:0.00}, ", value);
//}

// Compare multiple embeddings using Cosine Similarity
var catVector = await embeddingGenerator.GenerateVectorAsync("cat");
var dogVector = await embeddingGenerator.GenerateVectorAsync("dog");
var kittenVector = await embeddingGenerator.GenerateVectorAsync("kitten");

Console.WriteLine($"cat-dog similarity: {TensorPrimitives.CosineSimilarity(catVector.Span, dogVector.Span):F2}");
Console.WriteLine($"cat-kitten similarity: {TensorPrimitives.CosineSimilarity(catVector.Span, kittenVector.Span):F2}");
Console.WriteLine($"dog-kitten similarity: {TensorPrimitives.CosineSimilarity(dogVector.Span, kittenVector.Span):F2}");