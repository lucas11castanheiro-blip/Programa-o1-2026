using Aula05.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SaleOrder;

namespace Aula05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            SaleOrder.Customer c1 = new SaleOrder.Customer();

            c1.Id = 1;
            c1.Name = "Maria";
            c1.BirthDate = new DateTime(1990, 5, 20);
            
            Console.WriteLine(c1.ToString());

            Console.WriteLine("Número de instâncias: " + SaleOrder.Customer.InstanceCount);

            SaleOrder.Customer c2= new SaleOrder.Customer() { 
            
                Id = 2,
                Name = "João",
                BirthDate = new DateTime(1985, 10, 15)
            };

            Console.WriteLine(c2.ToString());

            Console.WriteLine("Número de instâncias: " + SaleOrder.Customer.InstanceCount);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
