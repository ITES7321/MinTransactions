namespace MinTransactions.Shared
{
    public class Transaction
    {
        public String Id { get; set; } = String.Empty;
        public String SenderId { get; set; } = String.Empty;
        public String ReceiverId { get; set; } = String.Empty;
        public Double Amount { get; set; }
        public DateTime DateTime { get; set; }
        public String Comments { get; set; } = String.Empty;
        public String GroupId { get; set; } = String.Empty;
    }
}
