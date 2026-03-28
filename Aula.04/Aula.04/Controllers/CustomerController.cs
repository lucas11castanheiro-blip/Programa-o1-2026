using Aula._04.Models;
using Microsoft.AspNetCore.Mvc;


namespace Aula._04.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            
            int id = 1;

            Customer cu = new Customer(); //É um método, pois é um método construtor
                cu.CustomerId = id; // O . se chama: Modficador de acesso
                cu.EmailAddress = "meuemail@gmail.com";
                cu.FirstName = "Fulano";
                cu.LastName = "De Tal";

            Customer cu1 = new Customer {
                CustomerId = ++id,
                EmailAddress = "ciclano@gmail.com",
                FirstName = "Ciclano",
                LastName = "De Tal"
            };

            var cu2 = new Customer {
                CustomerId = ++id,
                EmailAddress = "Patricia@gmail.com",
                FirstName = "Patricia",
                LastName = "De Tal"
            };

            List<Customer> Customers = new List<Customer>();
            Customers.Add(cu);
            Customers.Add(cu1);
            Customers.Add(cu2);
            return View(Customers);

        }
    }
}
