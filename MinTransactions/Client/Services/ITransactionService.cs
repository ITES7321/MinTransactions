namespace MinTransactions.Client.Services
{
    public interface ITransactionService
    {
        List<Transaction> transactions { get; set; }
        Task GetTransactions();
        Task<Transaction> GetSingleTransaction(String Id);

    }
}
