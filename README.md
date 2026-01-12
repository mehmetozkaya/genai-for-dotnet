# GenAI for .NET: Build LLM Apps with OpenAI and Ollama
[![.NET](https://img.shields.io/badge/.NET-9-blueviolet)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Udemy Course](https://img.shields.io/badge/Enroll%20on-Udemy-blue)](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=JANU26)

<img width="1371" height="489" alt="Image" src="https://github.com/user-attachments/assets/54360bbb-c541-4f2f-93f0-e87948a3c12e" />

Welcome! This repository contains the complete source code for my comprehensive Udemy course, **"GenAI for .NET: Build LLM Apps with OpenAI and Ollama"**. This course is a practical, hands-on journey designed to take you from a curious .NET developer to a confident .NET AI developer, capable of building the next generation of intelligent software.

### ✨ [➡️ Click Here to Enroll in the Full Course on Udemy!](https://www.udemy.com/course/genai-for-net-build-llm-apps-with-openai-and-ollama/?couponCode=JANU26) ✨

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

### ⭐ About the Instructor
Hi, I'm Mehmet Ozkaya, a software architect passionate about designing and building modern distributed systems with .NET. My focus is on bridging the gap between cutting-edge Generative AI technology and the practical needs of enterprise software development.

---

### 🤝 Contributing & Feedback
This repository is intended for educational purposes. If you find a bug, have a suggestion, or want to provide feedback on the course, please open an issue in this repository. Your feedback is incredibly valuable!

---

### 📜 License

This project is licensed under the MIT License. See the LICENSE file for details.

