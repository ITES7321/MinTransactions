namespace MinTransactions.Shared
{
    public class Group
    {
        public String Id { get; set; } = String.Empty;
        public String Name { get; set; } = String.Empty;

        public List<Transaction> TransactionHistory = new();

        public List<Person> Members = new();

        public List<Transaction> GroupBalance = new();

    }
}
