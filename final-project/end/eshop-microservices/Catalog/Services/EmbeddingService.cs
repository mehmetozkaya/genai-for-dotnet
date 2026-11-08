using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Services
{
    public class EmbeddingService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<float[]> GenerateEmbedding(string text)
        {
           var response = await _httpClient.PostAsJsonAsync( "http://localhost:11434/api/embed",
            new
            {
                model = "nomic-embed-text",
                input = text
            });

            response.EnsureSuccessStatusCode();
           var result = await response.Content.ReadFromJsonAsync<EmbeddingResponse>();
           return result!.Embeddings[0];

            
        }

        private sealed class EmbeddingResponse
        {
            public float[][] Embeddings { get; set; } = [];
        }

        
    }
    
}