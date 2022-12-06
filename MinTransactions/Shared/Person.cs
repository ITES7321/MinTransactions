namespace MinTransactions.Shared
{
    public class Person
    {
        public String Id { get; set; } = String.Empty;
        public Double Balance { get; set; }
        public String Name { get; set; } = String.Empty;
        public String Contact { get; set; } = String.Empty;
        public List<Transaction> TransactionHistory { get; set; } = new();
        public List<Group> Groups { get; set; } = new();

    }
}
