namespace MinTransactions.Client.Services
{
    public interface IPersonService
    {
        List<Person> persons { get; set; }
        Task GetPersons();
        Task<Person> GetSinglePerson(String Id);

    }
}
