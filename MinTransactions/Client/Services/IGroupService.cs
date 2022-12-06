namespace MinTransactions.Client.Services
{
    public interface IGroupService
    {
        List<Group> groups { get; set; }
        Task GetGroups();
        Task<Group> GetSingleGroup(String Id);

    }
}
