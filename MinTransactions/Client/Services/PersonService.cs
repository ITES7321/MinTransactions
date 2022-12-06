using MinTransactions.Shared;
using System.Net.Http.Json;

namespace MinTransactions.Client.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _http;
        public PersonService(HttpClient http)
        {
            _http = http;
        }
        public List<Person> persons { get; set; } = new List<Person>();

        public async Task GetPersons()
        {
            var result = await _http.GetFromJsonAsync<List<Person>>("api/person");
            if (result != null)
                persons = result;
        }

        public async Task<Person> GetSinglePerson(string Id)
        {
            var result = await _http.GetFromJsonAsync<Person>($"api/person/{Id}");
            if (result != null)
                return result;
            throw new Exception("Person Not Found!");
        }
    }
}
