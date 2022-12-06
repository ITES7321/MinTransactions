using Microsoft.AspNetCore.Mvc;

namespace MinTransactions.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public static List<Transaction> transactions = new List<Transaction>
        {
            new Transaction
            {
                Id = "SV21",
                SenderId = "1",
                ReceiverId = "2",
                Amount = 3500.6,
                DateTime = new DateTime(2022,11,10,14,30,21),
                Comments = "For Food",
                GroupId = "1"
            },
            new Transaction
            {
                Id = "PRS11",
                SenderId = "1",
                ReceiverId = "2",
                Amount = 3500.6,
                DateTime = new DateTime(2022,11,10,14,30,21),
                Comments = "For Food",
                GroupId = "1"
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<Transaction>>> GetTransactions()
        {
            return Ok(transactions);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Transaction>> GetSingleTransaction(String Id)
        {
            var transaction = transactions.FirstOrDefault(h => h.Id.Equals(Id));
            if (transaction == null)
            {
                return NotFound("Transaction Not Found!");
            }
            return Ok(transaction);
        }
    }
}
