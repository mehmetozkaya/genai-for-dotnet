# GenAI for .NET: Build LLM Apps with OpenAI and Ollama
[![.NET](https://img.shields.io/badge/.NET-9-blueviolet)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Udemy Course](https://img.shields.io/badge/Enroll%20on-Udemy-blue)](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=FEBR26)

> [!IMPORTANT]
> **Course update (October 2026):** GitHub retired **GitHub Models** on 30 July 2026. Some videos use it to reach OpenAI models.
> The course code still works. You only change the provider settings: endpoint, API key and model name.
> 👉 **[Read the migration guide](#-course-update-migrating-away-from-github-models)**

<img width="1371" height="489" alt="Image" src="https://github.com/user-attachments/assets/54360bbb-c541-4f2f-93f0-e87948a3c12e" />

Welcome! This repository contains the complete source code for my comprehensive Udemy course, **"GenAI for .NET: Build LLM Apps with OpenAI and Ollama"**. This course is a practical, hands-on journey designed to take you from a curious .NET developer to a confident .NET AI developer, capable of building the next generation of intelligent software.

### ✨ [➡️ Click Here to Enroll in the Full Course on Udemy!](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=FEBR26) ✨

---

## 🎓 About The Course

This is not a theory course. We will be in the code, building a wide range of sophisticated GenAI applications from the ground up. You'll learn to master the entire AI development pipeline, from basic conversations with a Large Language Model (LLM) to building a complete, AI-powered microservices application.

Develop AI-Powered Distributed Architectures using .NET Aspire and GenAI to develop EShop Catalog and Basket microservices integrate with Backing services including PostgreSQL, Redis, RabbitMQ, Keycloak, Ollama and Semantic Kernel to Create Intelligent E-Shop Solutions.

A key philosophy of this course is **flexibility**. You'll learn how to build applications using Microsoft's new `Microsoft.Extensions.AI` abstractions, allowing you to seamlessly switch between best-in-class cloud models from **OpenAI** (via OpenAI, Azure AI Foundry or OpenRouter) and powerful, private, and free-to-run local models with **Ollama**.

---

## 🚀 What You'll Build and Learn

Throughout this course, you will get hands-on experience building a variety of real-world AI applications:

* **💬 Chat & Text Analysis:** Build your first intelligent chatbots, perform complex text analysis (classification, summarization, sentiment analysis), and master prompt engineering to control AI behavior.

* **🛠️ Function Calling:** Give your AI a "superpower" by teaching it to execute your own C# methods to fetch real-time data or perform actions.

* **🔍 Vector Search & Embeddings:** Learn the core of all modern recommendation engines. Turn any text into a numerical vector of its "meaning" and perform powerful semantic searches.

* **📚 Retrieval-Augmented Generation (RAG):** Construct a complete RAG pipeline from scratch. Build an AI that can answer questions based on **your own private documents**, grounding its responses in facts and eliminating hallucinations.

* **🖼️ Image Analysis:** Go beyond text and give your AI the gift of sight. Build applications that can "see" and interpret the contents of an image, and even extract structured data from what they see, like monitoring traffic cameras.

* **🏆 Final Project: E-Shop Semantic Search:** Put all your skills together to build a complete AI-powered eShop application. You will implement a cutting-edge semantic search feature in a distributed microservices application using **.NET Aspire**, a **Qdrant** Vector Database, and models like **gpt-5-mini**.

---

## 💻 Technology Stack

We use a modern, powerful, and production-ready tech stack:

* **.NET 9**
* **ASP.NET Core (Minimal APIs, Blazor)**
* **.NET Aspire** for orchestration
* **OpenAI models** (gpt-5-mini, gpt-4o-mini, text-embedding-3-small) via OpenAI, Azure AI Foundry or OpenRouter. *The videos use GitHub Models, which is now retired; see the [Course Update](#-course-update-migrating-away-from-github-models).*
* **Ollama** (Llama 3.2, LLaVA, all-minilm)
* **Qdrant** Vector Database
* **Microsoft.Extensions.AI** Abstractions
* **Entity Framework Core** & **PostgreSQL**
* **Docker**

---

## 📂 Repository Structure

The projects mirror the course sections:

| Folder | What you build | Section |
|---|---|---|
| `genai-dotnet/TextCompletion`, `TextCompletion_Ollama` | Text completion, streaming, classification, summarization, sentiment analysis, structured output, chat app | 5 |
| `genai-dotnet/FunctionCall` | Function calling with C# methods | 5 |
| `genai-dotnet/Embeddings` | Embeddings and cosine similarity | 6 |
| `genai-dotnet/VectorSearch`, `VectorSearch_Ollama` | Vector search with an in-memory vector store | 6 |
| `genai-dotnet/ChatApp_RAG`, `ChatApp_RAG_Ollama`, `ChatApp_RAG_Qdrant` | RAG chat apps (SQLite, Ollama, Qdrant + .NET Aspire) | 7 |
| `genai-dotnet/ImageAnalysis`, `ImageAnalysis_Ollama`, `TraficCamAnalysis` | Image analysis and structured data from images | 8 |
| `final-project/start`, `final-project/end` | EShop semantic search with .NET Aspire and Qdrant | 9 |

---

## 🏁 Getting Started

### Prerequisites

To run these projects, you will need the following installed on your machine:
* **.NET 9 SDK** (or later)
* **Docker Desktop** (essential for Ollama and Qdrant)
* An IDE like **Visual Studio 2022** or **Visual Studio Code** (with the C# Dev Kit).

### Configuration

The `*_Ollama` projects run against your local Ollama and need no API key.

All other projects need an AI provider. The videos show GitHub Models (`GitHubModels:Token`), which is now retired. Follow the **Course Update** below to choose a provider and set it up. We use .NET's `user-secrets` feature to keep API keys safe and out of source control.

---

# 🚨 Course Update: Migrating Away from GitHub Models

GitHub fully retired GitHub Models on **30 July 2026** ([GitHub changelog](https://github.blog/changelog/2026-07-30-github-models-is-now-retired/)). Calls to `models.github.ai` or `models.inference.ai.azure.com` now fail, for example with `HTTP 400`, `unavailable_model` or connection timeout errors.

**What stays the same:** everything you learn in the course. Every project talks to the model through `Microsoft.Extensions.AI` (`IChatClient`, `IEmbeddingGenerator`) on top of the official OpenAI SDK. Your chat, streaming, structured output, function calling, embeddings, vector search, RAG and image analysis code stays exactly as shown in the videos.

**What changes:** only the client setup at the top of `Program.cs`, about 5 lines per project. After this update, the provider is a setting, not code. You can switch between OpenRouter, OpenAI, Azure AI Foundry and Ollama by changing user secrets, without touching the code again.

## Step 1: Pick a provider

| Provider | Cost | Chat, streaming, structured output, function calling (Section 5) | Embeddings (Sections 6, 7, 9) | Images (Section 8) |
|---|---|---|---|---|
| ⭐ **OpenRouter + OpenAI models** (recommended) | Pay-as-you-go. A few dollars of credit covers the whole course | ✅ | ✅ same `text-embedding-3-small` | ✅ |
| **OpenAI Platform** | Pay-as-you-go | ✅ | ✅ same `text-embedding-3-small` | ✅ |
| **Azure AI Foundry** | Your Azure subscription | ✅ | ✅ same `text-embedding-3-small` | ✅ |
| **Ollama** (local) | Free | ✅ | ✅ `all-minilm` (different vector size, see Step 4) | ✅ `llava` |
| OpenRouter free models (`openrouter/free`) | Free, 50 requests/day | ✅ | ❌ | ✅ |
| Groq free tier | Free | ✅ | ❌ | ❌ |

**Which one should I choose?**

* **OpenRouter** is closest to the videos. It serves the same OpenAI models with the **same model IDs** the course uses (`openai/gpt-5-mini`, `openai/text-embedding-3-small`). Only the endpoint and key change, and the embedding vectors keep the same size (1536).
* **OpenAI Platform** is the same models straight from OpenAI. The model IDs have no `openai/` prefix.
* **Azure AI Foundry** is the replacement GitHub recommends, and the best fit if your company already has an Azure subscription. Its setup is covered in Section 4, in the *"Azure OpenAI from Azure AI Foundry and OpenAI platform"* lecture.
* **Ollama** is free, private and offline. The course already teaches it, and the `*_Ollama` projects work as they are.
* **Free cloud options** work for the Section 5 text lessons only. Neither OpenRouter's free router nor Groq's free tier offers embedding models, and Groq's recommended free model (`openai/gpt-oss-20b`) is text-only.

## Step 2: Save your provider settings (user secrets)

Each project reads four settings. Run these commands in the project folder, for example `genai-dotnet/TextCompletion`:

```bash
dotnet user-secrets set "AI:Endpoint" "<endpoint>"
dotnet user-secrets set "AI:ApiKey" "<api-key>"
dotnet user-secrets set "AI:ChatModel" "<chat-model>"
dotnet user-secrets set "AI:EmbeddingModel" "<embedding-model>"
```

The projects in this repository already have user secrets enabled. If you create your own project while following the videos, run `dotnet user-secrets init` first.

| Provider | `AI:Endpoint` | `AI:ApiKey` | `AI:ChatModel` | `AI:EmbeddingModel` |
|---|---|---|---|---|
| ⭐ OpenRouter | `https://openrouter.ai/api/v1` | Create at [openrouter.ai/keys](https://openrouter.ai/keys) | `openai/gpt-5-mini` | `openai/text-embedding-3-small` |
| OpenAI Platform | `https://api.openai.com/v1` | Create at [platform.openai.com/api-keys](https://platform.openai.com/api-keys) | `gpt-5-mini` | `text-embedding-3-small` |
| Azure AI Foundry | `https://<your-resource>.openai.azure.com/openai/v1/` | Key of your Azure OpenAI resource | Your chat deployment name, e.g. `gpt-5-mini` | Your embedding deployment name, e.g. `text-embedding-3-small` |
| Ollama | `http://localhost:11434/v1` | `ollama` (any non-empty value) | `llama3.2` (use `llava` for Section 8) | `all-minilm` |
| OpenRouter free | `https://openrouter.ai/api/v1` | Your OpenRouter key | `openrouter/free` | — |
| Groq free | `https://api.groq.com/openai/v1` | Create at [console.groq.com/keys](https://console.groq.com/keys) | `openai/gpt-oss-20b` | — |

> [!TIP]
> Model names change often. If a model is retired, pick a current one from your provider's model list and update `AI:ChatModel` or `AI:EmbeddingModel`. You don't need to change any code.

## Step 3: Update the client setup in `Program.cs`

Replace only the lines that read `GitHubModels:Token` and set the `models.github.ai` (or `models.inference.ai.azure.com`) endpoint. Everything below them stays the same.

### Console projects

These are `TextCompletion`, `FunctionCall`, `Embeddings`, `VectorSearch`, `ImageAnalysis` and `TraficCamAnalysis`.

**a) Read the settings and create one OpenAI-compatible client.** This part is the same in every project:

```csharp
// get provider settings from user secrets (see README: Course Update)
IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

var endpoint = config["AI:Endpoint"] ?? throw new InvalidOperationException("Missing configuration: AI:Endpoint.");
var apiKey = config["AI:ApiKey"] ?? throw new InvalidOperationException("Missing configuration: AI:ApiKey.");

var openAIClient = new OpenAIClient(
    new ApiKeyCredential(apiKey),
    new OpenAIClientOptions { Endpoint = new Uri(endpoint) });
```

**b) Create the client your project needs.** Keep the variable names you already use:

```csharp
// Chat client: TextCompletion, ImageAnalysis, TraficCamAnalysis, Embeddings
var chatModel = config["AI:ChatModel"] ?? throw new InvalidOperationException("Missing configuration: AI:ChatModel.");

IChatClient client = openAIClient.GetChatClient(chatModel).AsIChatClient();
```

```csharp
// Chat client with function invocation: FunctionCall
var chatModel = config["AI:ChatModel"] ?? throw new InvalidOperationException("Missing configuration: AI:ChatModel.");

IChatClient client =
    new ChatClientBuilder(openAIClient.GetChatClient(chatModel).AsIChatClient())
    .UseFunctionInvocation()
    .Build();
```

```csharp
// Embedding generator: Embeddings (named embeddingGenerator), VectorSearch (named generator)
var embeddingModel = config["AI:EmbeddingModel"] ?? throw new InvalidOperationException("Missing configuration: AI:EmbeddingModel.");

IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator =
    openAIClient.GetEmbeddingClient(embeddingModel).AsIEmbeddingGenerator();
```

### RAG chat app (`ChatApp_RAG`)

In `Program.cs`, replace the `credential`, `openAIOptions`, `ghModelsClient`, `chatClient` and `embeddingGenerator` lines with:

```csharp
var endpoint = builder.Configuration["AI:Endpoint"] ?? throw new InvalidOperationException("Missing configuration: AI:Endpoint.");
var apiKey = builder.Configuration["AI:ApiKey"] ?? throw new InvalidOperationException("Missing configuration: AI:ApiKey.");
var chatModel = builder.Configuration["AI:ChatModel"] ?? throw new InvalidOperationException("Missing configuration: AI:ChatModel.");
var embeddingModel = builder.Configuration["AI:EmbeddingModel"] ?? throw new InvalidOperationException("Missing configuration: AI:EmbeddingModel.");

var openAIClient = new OpenAIClient(
    new ApiKeyCredential(apiKey),
    new OpenAIClientOptions { Endpoint = new Uri(endpoint) });

var chatClient = openAIClient.GetChatClient(chatModel).AsIChatClient();
var embeddingGenerator = openAIClient.GetEmbeddingClient(embeddingModel).AsIEmbeddingGenerator();
```

### EShop final project (`Catalog` microservice)

In `Catalog/Program.cs`, replace the `// Add AI Chat Client` block, from `credential` down to `embeddingGenerator`, with the same lines as the RAG chat app above. Keep the `AddChatClient` and `AddEmbeddingGenerator` registrations. Run the `dotnet user-secrets set` commands from Step 2 in the **`Catalog`** project folder.

### RAG chat app with Qdrant and .NET Aspire (`ChatApp_RAG_Qdrant`)

This project gets its AI connection from the Aspire AppHost as a connection string.

**Azure AI Foundry: no code change.** Create deployments named `gpt-4o-mini` and `text-embedding-3-small`, or change those names in `ChatApp_RAG_Qdrant.Web/Program.cs`. Then, in the **AppHost** project folder, run:

```bash
dotnet user-secrets set "ConnectionStrings:openai" "Endpoint=https://<your-resource>.openai.azure.com/;Key=<your-key>"
```

**OpenRouter, OpenAI or Ollama:** the Web project uses the *Azure* OpenAI client, which only talks to Azure endpoints. Switch it to the standard OpenAI client:

```bash
cd ChatApp_RAG_Qdrant.Web
dotnet add package Aspire.OpenAI --version 9.4.0-preview.1.25378.8
```

```csharp
// ChatApp_RAG_Qdrant.Web/Program.cs
var openai = builder.AddOpenAIClient("openai");   // was: builder.AddAzureOpenAIClient("openai")
openai.AddChatClient("openai/gpt-5-mini")         // your provider's chat model ID
    .UseFunctionInvocation()
    .UseOpenTelemetry(configure: c =>
        c.EnableSensitiveData = builder.Environment.IsDevelopment());
openai.AddEmbeddingGenerator("openai/text-embedding-3-small");   // your provider's embedding model ID
```

Then, in the **AppHost** project folder:

```bash
dotnet user-secrets set "ConnectionStrings:openai" "Endpoint=https://openrouter.ai/api/v1;Key=<your-key>"
```

## Step 4: Embedding vector size (only if you change the embedding model)

If you keep **`text-embedding-3-small`** (OpenRouter, OpenAI or Azure AI Foundry), skip this step. The vector size stays 1536.

A different embedding model produces vectors of a different size, for example 384 for Ollama `all-minilm` or 768 for `nomic-embed-text`. The stored vector size must match:

1. Update the vector size:
   * `ChatApp_RAG` and `ChatApp_RAG_Qdrant`: `VectorDimensions` in `Services/IngestedChunk.cs`
   * EShop `Catalog`: `Dimensions` in `Models/ProductVector.cs`
2. Delete the old vectors, which were created with 1536 dimensions:
   * `ChatApp_RAG`: delete `vector-store.db` in the app's `bin` output folder.
   * Qdrant projects: delete the Qdrant container and its data volume in Docker Desktop. Qdrant keeps the old collection between runs.

`Embeddings` and `VectorSearch` keep vectors in memory, so they need no change.

## Following the videos

* **Section 4:** skip the *"GitHub Models"* and *"Create Access Token for GitHub Models"* lectures. Watch the Azure AI Foundry / OpenAI and Ollama lectures, then set up your provider with Steps 1 and 2.
* **Sections 5 to 9:** code along as shown. Wherever the video creates the client with `GitHubModels:Token`, use the setup from Step 3 instead. The rest of the code is the same.
* **Ollama lectures and `*_Ollama` projects** are not affected.

## Troubleshooting

| Error | Fix |
|---|---|
| `Missing configuration: AI:...` | Run the Step 2 commands **in that project's folder**. Check with `dotnet user-secrets list`. |
| `401 Unauthorized` | The API key is wrong, or it was saved in a different project folder. |
| `404`, `model not found` or `decommissioned` | The model ID is misspelled or retired. Use a current ID from your provider's model list. |
| `429 Too Many Requests` | You hit a free-tier limit. Wait, add credit, or switch provider. |
| Structured output or function calling fails on a free model | That model doesn't support the feature. Use `openai/gpt-5-mini` or `openrouter/free`, which picks a model that supports what your request needs. |
| Qdrant vector dimension error | See Step 4. |

---

This project is licensed under the MIT License. See the LICENSE file for details.
