using System.Collections.Generic;
using Aula._04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula._04.Controllers
{
    public class PlantsController : Controller
    {
        public IActionResult Index()
        {
            List<Plant> plants = new List<Plant>
            {
                new Plant
                {
                    Name = "Girassol",
                    Description = "Flor amarela com cheiro de queimado",
                    Color = "Amarela",
                    Count = 1,
                    Size = 1.3,
                },
                new Plant
                {
                    Name = "Amélia",
                    Description = "Flor branca com cheiro doce",
                    Color = "Branca",
                    Count = 1,
                    Size = 0.2,
                },
                new Plant
                {
                    Name = "Rosa",
                    Description = "Flor Vermelha com cheiro de mato",
                    Color = "Vermelha",
                    Count = 10,
                    Size = 0.5
                },
                new Plant
                {
                    Name = "Copo-De-Leite",
                    Description = "FLor branca e em formato de copo, com cheiro doce",
                    Color = "Branca",
                    Count = 7,
                    Size = 0.4,
                },
                new Plant
                {
                    Name = "Orquídeas",
                    Description = "Flor roxa com cheiro de mato e meio doce",
                    Color = "roxa",
                    Count = 4,
                    Size = 0.4,
                },
                new Plant
                {
                    Name = "Lírio",
                    Description = "Flor rosa com cheiro agradável",
                    Color = "Rosa",
                    Count = 12,
                    Size = 0.3,
                },
                new Plant
                {
                    Name = "Margarida",
                    Description = "Flor branca e simples",
                    Color = "Branca",
                    Count = 16,
                    Size = 0.5,
                },
                new Plant
                {
                    Name = "Lavanda",
                    Description = "Flor roxa com cheiro muito bom e aparência de trigo",
                    Color = "Roxa",
                    Count = 19,
                    Size = 0.6,
                },
                new Plant
                {
                    Name = "Antúurio",
                    Description = "Flor vermelha com cheiro de pólem",
                    Color = "Vermelha",
                    Count = 14,
                    Size = 0.7,
                },
                new Plant
                {
                    Name = "Cravo",
                    Description = "Flor vermelha com cheiro forte e natural",
                    Color = "Vermelha",
                    Count = 1,
                    Size = 1,
                }
            };

            return View(plants);
        }
    }
}
