# GenAI for .NET: Build LLM Apps with OpenAI and Ollama
[![.NET](https://img.shields.io/badge/.NET-9-blueviolet)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Udemy Course](https://img.shields.io/badge/Enroll%20on-Udemy-blue)](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=FEBR26)

<img width="1371" height="489" alt="Image" src="https://github.com/user-attachments/assets/54360bbb-c541-4f2f-93f0-e87948a3c12e" />

Welcome! This repository contains the complete source code for my comprehensive Udemy course, **"GenAI for .NET: Build LLM Apps with OpenAI and Ollama"**. This course is a practical, hands-on journey designed to take you from a curious .NET developer to a confident .NET AI developer, capable of building the next generation of intelligent software.

### ✨ [➡️ Click Here to Enroll in the Full Course on Udemy!](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=FEBR26) ✨

---

## 🎓 About The Course

This is not a theory course. We will be in the code, building a wide range of sophisticated GenAI applications from the ground up. You'll learn to master the entire AI development pipeline, from basic conversations with a Large Language Model (LLM) to building a complete, AI-powered microservices application.

Develop AI-Powered Distributed Architectures using .NET Aspire and GenAI to develop EShop Catalog and Basket microservices integrate with Backing services including PostgreSQL, Redis, RabbitMQ, Keycloak, Ollama and Semantic Kernel to Create Intelligent E-Shop Solutions.

A key philosophy of this course is **flexibility**. You'll learn how to build applications using Microsoft's new `Microsoft.Extensions.AI` abstractions, allowing you to seamlessly switch between best-in-class cloud models from **OpenAI** (via GitHub Models) and powerful, private, and free-to-run local models with **Ollama**.

---

## 🚀 What You'll Build and Learn

Throughout this course, you will get hands-on experience building a variety of real-world AI applications:

* **💬 Chat & Text Analysis:** Build your first intelligent chatbots, perform complex text analysis (classification, summarization, sentiment analysis), and master prompt engineering to control AI behavior.

* **🛠️ Function Calling:** Give your AI a "superpower" by teaching it to execute your own C# methods to fetch real-time data or perform actions.

* **🔍 Vector Search & Embeddings:** Learn the core of all modern recommendation engines. Turn any text into a numerical vector of its "meaning" and perform powerful semantic searches.

* **📚 Retrieval-Augmented Generation (RAG):** Construct a complete RAG pipeline from scratch. Build an AI that can answer questions based on **your own private documents**, grounding its responses in facts and eliminating hallucinations.

* **🖼️ Image Analysis:** Go beyond text and give your AI the gift of sight. Build applications that can "see" and interpret the contents of an image, and even extract structured data from what they see, like monitoring traffic cameras.

* **🏆 Final Project: E-Shop Semantic Search:** Put all your skills together to build a complete AI-powered eShop application. You will implement a cutting-edge semantic search feature in a distributed microservices application using **.NET Aspire**, a **Qdrant** Vector Database, and models like **gpt-4o-mini**.

---

## 💻 Technology Stack

We use a modern, powerful, and production-ready tech stack:

* **.NET 9**
* **ASP.NET Core (Minimal APIs, Blazor)**
* **.NET Aspire** for orchestration
* **OpenAI / GitHub Models** (gpt-4o-mini, text-embedding-3-small)
* **Ollama** (Llama 3.2, LLaVA, all-minilm)
* **Qdrant** Vector Database
* **Microsoft.Extensions.AI** Abstractions
* **Entity Framework Core** & **PostgreSQL**
* **Docker**

---

## 📂 Repository Structure

This repository is organized by section, mirroring the structure of the Udemy course. Each numbered folder represents a self-contained project that we build together.

* `01-TextCompletionSentiment`: Fundamentals of text generation, streaming, structured output, and analysis.
* `02-ChatApp`: Building an interactive, context-aware chatbot.
* `03-FunctionCalling`: Enabling the LLM to execute C# code.
* `04-VectorSearch`: Introduction to embeddings and vector databases.
* `05-RAGApplication`: Building a complete RAG app with a custom knowledge base.
* `06-ImageAnalysis`: Multimodal AI with vision models.
* `07-EShopVectorSearch`: The final capstone project using .NET Aspire and microservices.

---

## 🏁 Getting Started

### Prerequisites

To run these projects, you will need the following installed on your machine:
* **.NET 9 SDK** (or later)
* **Docker Desktop** (essential for Ollama and Qdrant)
* An IDE like **Visual Studio 2022** or **Visual Studio Code** (with the C# Dev Kit).

### Configuration

These projects require API keys to connect to AI services. We use .NET's `user-secrets` feature to keep these keys safe and out of source control.

**1. For OpenAI / GitHub Models:**

Navigate to a project directory (e.g., `01-TextCompletionSentiment`) in your terminal and run:
```bash
dotnet user-secrets init
dotnet user-secrets set "GitHubModels:Token" "YOUR_GITHUB_PAT_HERE"
```

2. For the Final eShop Project (using .NET Aspire):
Configuration is handled by the .AppHost project. Navigate to the EShopVectorSearch.AppHost directory and set the secret there:
```bash
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:openai" "Endpoint=https://models.inference.ai.azure.com;Key=YOUR_GITHUB_PAT_HERE"
```

---

# 🚨 Course Update: Migrating Away from GitHub Models

**Notice:** GitHub has recently retired its free GitHub Models service. If you are receiving `HTTP 400`, `unavailable_model`, or connection timeout errors, this is the reason.

The great news is that because we architected our application using standard abstractions (the official OpenAI SDK and `Microsoft.Extensions.AI`), our core application logic is completely immune to this platform shift. We do not need to rewrite our chat logic, streaming implementations, or structured JSON outputs.

We simply need to point our application to a new provider by changing the **Base URL (Endpoint)**, the **API Key**, and the **Model Name**.

Below are the best free, OpenAI-compatible alternatives and exactly how to configure them.

---

## 🚀 The Free Tier Alternatives

### Option 1: Groq (Recommended for Cloud Speed)
Groq uses specialized hardware (LPUs) to run open-source models at blistering speeds. It is currently the best drop-in replacement for fast, free inference.

1. **Get an API Key:** Go to [console.groq.com](https://console.groq.com), create an account, and generate a new API key.
2. **Update Secrets:** Save this key in your .NET User Secrets (e.g., `dotnet user-secrets set "Groq:Token" "your-key"`).
3. **Endpoint:** `https://api.groq.com/openai/v1`
4. **Recommended Model:** `llama-3.1-8b-instant` or `mixtral-8x7b-32768`

### Option 2: OpenRouter (Best for Model Variety)
OpenRouter is a unified API gateway that routes requests to dozens of AI providers. They maintain a specific endpoint that routes exclusively to completely free models.

1. **Get an API Key:** Go to [openrouter.ai](https://openrouter.ai), sign up, and generate a key.
2. **Update Secrets:** Save this key (e.g., `dotnet user-secrets set "OpenRouter:Token" "your-key"`).
3. **Endpoint:** `https://openrouter.ai/api/v1`
4. **Recommended Model:** `openrouter/free` (This automatically selects the best available free model).

### Option 3: Local Ollama (Best for Privacy & Offline)
As covered earlier in this course, you can run LLMs directly on your own machine. This costs nothing and requires no API keys.

1. **Start Ollama:** Ensure Ollama is installed and running on your machine.
2. **Pull a Model:** Open your terminal and run `ollama run llama3.1`.
3. **Update Secrets:** No token is strictly required, but the OpenAI SDK expects a non-empty string. You can pass `"ollama"`.
4. **Endpoint:** `http://localhost:11434/v1` (Ollama natively supports OpenAI SDK routing).
5. **Recommended Model:** `llama3.1` (or whichever model you downloaded).

---

## 💻 C# Code Migration

You only need to update the configuration and client initialization at the very top of your `Program.cs`. **All of your use-case regions (Basic Completion, Streaming, Classification, Structured Output, and ChatApp) remain exactly the same.**

Replace the top section of your code with the following:

```csharp
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using OpenAI;
using System.ClientModel;
using System.Text.Json.Serialization;

// 1. Get credentials from user secrets
IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

// 2. Select your provider (Uncomment the one you want to use)

// --- OPTION A: GROQ ---
// var apiKey = config["Groq:Token"] ?? throw new InvalidOperationException("Missing Groq token.");
// var endpoint = new Uri("https://api.groq.com/openai/v1");
// var modelId = "llama-3.1-8b-instant";

// --- OPTION B: OPENROUTER ---
var apiKey = config["OpenRouter:Token"] ?? throw new InvalidOperationException("Missing OpenRouter token.");
var endpoint = new Uri("https://openrouter.ai/api/v1");
var modelId = "openrouter/free";

// --- OPTION C: OLLAMA (Local) ---
// var apiKey = "ollama-local"; // SDK requires a string, even if unused locally
// var endpoint = new Uri("http://localhost:11434/v1");
// var modelId = "llama3.1";


// 3. Initialize the OpenAI Client with the new endpoint
var credential = new ApiKeyCredential(apiKey);
var options = new OpenAIClientOptions()
{
    Endpoint = endpoint
};

// 4. Wrap it in the Microsoft.Extensions.AI IChatClient interface
IChatClient client = new OpenAIClient(credential, options)
    .GetChatClient(modelId)
    .AsIChatClient();


// =================================================================
// THE REST OF YOUR CODE REMAINS UNCHANGED BELOW THIS LINE
// =================================================================

#region Basic Completion
// ... (your existing code)
#endregion

#region Streaming
// ... (your existing code)
#endregion
```

---

## 🐍 Python Migration Example

For students translating these concepts to Python using the official `openai` package, the pattern is identical. Change the `base_url`, `api_key`, and `model` arguments.

```python
from openai import OpenAI
import os

# Swap these variables for Groq, OpenRouter, or Ollama
API_KEY = os.getenv("GROQ_API_KEY") 
BASE_URL = "https://api.groq.com/openai/v1"
MODEL_NAME = "llama-3.1-8b-instant"

client = OpenAI(
    api_key=API_KEY,
    base_url=BASE_URL
)

# The rest of the API surface remains standard
response = client.chat.completions.create(
    model=MODEL_NAME,
    messages=[
        {"role": "system", "content": "You are a helpful assistant."},
        {"role": "user", "content": "What is AI? Explain in max 20 words."}
    ],
    stream=True # Works perfectly with compatible providers
)

for chunk in response:
    if chunk.choices[0].delta.content is not None:
        print(chunk.choices[0].delta.content, end="")
```

---

## 🟩 Node.js / TypeScript Migration Example

For JavaScript/TypeScript developers using the `openai` npm package, update the `baseURL` property in the client configuration.

```javascript
import OpenAI from 'openai';

// Swap these variables for Groq, OpenRouter, or Ollama
const apiKey = process.env.OPENROUTER_API_KEY;
const baseURL = "https://openrouter.ai/api/v1";
const modelName = "openrouter/free";

const openai = new OpenAI({
  apiKey: apiKey,
  baseURL: baseURL 
});

async function main() {
  // The completion logic remains identical
  const completion = await openai.chat.completions.create({
    messages: [
      { role: "system", content: "You are a helpful assistant." },
      { role: "user", content: "What is AI? Explain in max 20 words." }
    ],
    model: modelName,
  });

  console.log(completion.choices[0].message.content);
}

main();
```

---

This project is licensed under the MIT License. See the LICENSE file for details.

