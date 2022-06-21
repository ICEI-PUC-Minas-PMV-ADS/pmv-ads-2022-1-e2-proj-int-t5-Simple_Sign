using Microsoft.AspNetCore.Mvc;
using SimpleSign.Filters;
using SimpleSign.Models;
using System.Diagnostics;

namespace SimpleSign.Controllers
{
    [PaginaParaUsuarioLogado]
    public class HomeController : Controller
    {
          

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PrecisoAssinar()
        {
            return View();
        }

        public IActionResult Assinados()
        {
            return View( );
        }
    }
}