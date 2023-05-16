using Microsoft.AspNetCore.Mvc;

namespace EmployeeAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>() {
         new Employee() { Pets = "Cat", StreetAddress = "Beverly Hills", Email = "tc.apple.com", Name = "Tim Cook", ID = 1 },
         new Employee() { Pets = "Dog", StreetAddress = "Beverly Hills", Email = "lpage.alphabet.com", Name = "Larry Page", ID = 2 },
         new Employee() { Pets = "Dog", StreetAddress = "Beverly Hills", Email = "gbill@gmail.com", Name = "Bill Gates", ID = 3 },
         new Employee() { Pets = "Dog", StreetAddress = "Beverly Hills", Email = "wb@bh.com", Name = "Warren Buffet", ID = 4 },
         new Employee() { Pets = "Cat", StreetAddress = "Beverly Hills", Email = "muske.tesla.com", Name = "Elon Musk", ID = 5 },
         new Employee() { Pets = "Dog", StreetAddress = "Beverly Hills", Email = "jb.amazon.com", Name = "Jeff Besoz", ID = 6 },
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }
    }
}