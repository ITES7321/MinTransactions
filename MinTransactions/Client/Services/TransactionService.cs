using MinTransactions.Shared;
using System.Net.Http.Json;

namespace MinTransactions.Client.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly HttpClient _http;
        public TransactionService(HttpClient http)
        {
            _http = http;
        }
        public List<Transaction> transactions { get; set; } = new List<Transaction>();

        public async Task GetTransactions()
        {
            var result = await _http.GetFromJsonAsync<List<Transaction>>("api/transaction");
            if (result != null)
                transactions = result;
        }

        public async Task<Transaction> GetSingleTransaction(string Id)
        {
            var result = await _http.GetFromJsonAsync<Transaction>($"api/transaction/{Id}");
            if (result != null)
                return result;
            throw new Exception("Person Not Found!");
        }

        
    }
}
