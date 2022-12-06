using Microsoft.AspNetCore.Mvc;

namespace MinTransactions.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> persons = new()
        {
            new Person
            {
                Id = "2",
                Balance = 607.1,
                Name = "Sankalp Varshney",
                Contact = "+91 9560018536",
            },
            new Person
            {
                Id = "1",
                Balance = -1055.2,
                Name = "Pridum Bhatt",
                Contact = "+91 9810336372",
            },
            new Person
            {
                Id = "3",
                Balance = 2222.1,
                Name = "Paras Raj Dhar",
                Contact = "+91 1234567891",
            },
            new Person
            {
                Id = "4",
                Balance = 4122,
                Name = "Keshav",
                Contact = "+91 9876543219",
            }

        };
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPersons()
        {
            return Ok(persons);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Person>> GetSinglePerson(String Id)
        {
            var person = persons.FirstOrDefault(h => h.Id.Equals(Id));
            if (person == null)
            {
                return NotFound("Person Not Found!");
            }
            return Ok(person);
        }
    }
}
