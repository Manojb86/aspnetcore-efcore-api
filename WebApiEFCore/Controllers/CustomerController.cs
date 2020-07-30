using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApiEFCore.Data.DatabaseContext;

namespace WebApiEFCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext customerDbContext;
        public CustomerController(CustomerDbContext customerDbContext)
        {
            this.customerDbContext = customerDbContext;
        }

        [HttpGet]
        [Route("customer/all")]
        public IActionResult Index()
        {
            var customers = customerDbContext.Customers.ToList();
            return Ok(customers);
        }
    }
}