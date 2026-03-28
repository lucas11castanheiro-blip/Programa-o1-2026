using Atividade_23._03._26.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Classes;

//Uma imobiliária precisa organizar o seu catálogo de imóveis.
//Para isto, você deve organizar as entidades de forma que contemple os imóveis categorizando Casa, Apartamento, Venda ou Aluguel.
//Defina as classes de entidades separados em uma bibiloteca de Classes, depois, importe em seu projeto WEB.
//No controller principal, preencha um List<imovel> com 5 imóveis de diferentes tipos e impima-os na View,

namespace Atividade_23._03._26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var Housecatalog = new List<House>(){
              new House { Id = 1, Owner = "Ana Silva", Num = 123, Address = "Rua das Flores", Price = 850000f, Transacao = TransactionType.Sale},
              new House { Id = 3, Owner = "João Santos", Num = 90, Address = "Rua do Bosque", Price = 2500f, Transacao = TransactionType.Rent},
              new House { Id = 5, Owner = "Roberto Nunes", Num = 5, Address = "Alameda dos Anjos", Price = 450000f, Transacao = TransactionType.Sale},
            };

            var ApartamentCatalog = new List<Apartament>(){
                new Apartament { Id = 2, Owner = "Carlos Maia", Num = 45, Address = "Av. Paulista", Price = 3500f, Transacao = TransactionType.Rent },
                new Apartament { Id = 4, Owner = "Mariana Costa", Num = 101, Address = "Av. Beira Mar", Price = 1200000f, Transacao = TransactionType.Sale },
            };

            ViewBag.HouseCatalog = Housecatalog;
            ViewBag.ApartamentCatalog = ApartamentCatalog;

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
