using Atividade_WEB_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;

namespace Atividade_WEB_1.Controllers
{

    public class HomeController : Controller

    {
        private static Dictionary<string, double> _notas = new Dictionary<string, double>();

        [HttpGet]
        public IActionResult Notas()
        {
            string retorno = string.Empty;

            ViewBag.Media = CalcularMedia();
            ViewBag.MaiorNota = ObterMaiorNota();
            ViewBag.MenorNota = ObterMenorNota();
            ViewBag.Aprovados = ContarAprovados();
            ViewBag.Recuperacao = ContarRecuperacao();
            ViewBag.Reprovados = ContarReprovados();

            return View(_notas);
        }

        [HttpPost]
        public IActionResult AdicionarNota(string nome, double nota)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                _notas[nome] = nota;
            }
            return RedirectToAction("Notas");
        }

        private double CalcularMedia()
        {
            if (_notas.Count == 0) return 0;
            double soma = 0;
            foreach (double nota in _notas.Values) soma += nota;
            return soma / _notas.Count;
        }

        private double ObterMaiorNota()
        {
            if (_notas.Count == 0) return 0;
            double maior = double.MinValue;
            foreach (double nota in _notas.Values) if (nota > maior) maior = nota;
            return maior;
        }

        private double ObterMenorNota()
        {
            if (_notas.Count == 0) return 0;
            double menor = double.MaxValue;
            foreach (double nota in _notas.Values) if (nota < menor) menor = nota;
            return menor;
        }

        private int ContarAprovados()
        {
            int count = 0;
            foreach (double nota in _notas.Values) {
                if (nota >= 7.0) count++; };
            return count;
        }

        private int ContarRecuperacao()
        {
            int count = 0;
            foreach (double nota in _notas.Values) {
                if (nota >= 5.0 && nota < 7.0) count++; };
            return count;
        }

        private int ContarReprovados()
        {
            int count = 0;
            foreach (double nota in _notas.Values) {
                if (nota < 5.0) count++; };
            return count;
        }


        //=======================================////==================================================//
        public IActionResult Index()
        {
            return View();
        }

        //=======================================////==================================================//

        public IActionResult Privacy()
        {
            return View();
        }

        //=======================================////==================================================//

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //=======================================////==================================================//

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //=======================================////==================================================//

    }
}