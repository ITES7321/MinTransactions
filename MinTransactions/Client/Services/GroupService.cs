using MinTransactions.Shared;
using System.Net.Http.Json;

namespace MinTransactions.Client.Services
{
    public class GroupService : IGroupService
    {
        private readonly HttpClient _http;
        public GroupService(HttpClient http)
        {
            _http = http;
        }
        public List<Group> groups { get; set; } = new List<Group>();

        public async Task GetGroups()
        {
            var result = await _http.GetFromJsonAsync<List<Group>>("api/group");
            if (result != null)
                groups = result;
        }

        public async Task<Group> GetSingleGroup(string Id)
        {
            var result = await _http.GetFromJsonAsync<Group>($"api/group/{Id}");
            if (result != null)
                return result;
            throw new Exception("Person Not Found!");
        }
    }
}
