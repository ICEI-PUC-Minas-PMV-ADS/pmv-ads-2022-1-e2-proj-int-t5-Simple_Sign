using Microsoft.AspNetCore.Mvc;
using SimpleSign.Models;
using SimpleSign.Data;
using SimpleSign.Repositorio;

namespace SimpleSign.Controllers
{
    public class AssinaturaController : Controller
    {
        private readonly IAssinaturaRepositorio _assinaturaRepositorio;
        private readonly BancoContext _bancoContext;
        public AssinaturaController(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public AssinaturaController(IAssinaturaRepositorio assinaturaRepositorio)
        {
            _assinaturaRepositorio = (IAssinaturaRepositorio)assinaturaRepositorio;
        }
        public IActionResult Index()
        {
            List<AssinaturaModel> assinatura = _assinaturaRepositorio.BuscarTodos();

            return View(assinatura);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)

        {
            AssinaturaModel assinatura = _assinaturaRepositorio.ListarPorId(id);
            return View(assinatura);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            AssinaturaModel assinatura = _assinaturaRepositorio.ListarPorId(id);

            return View(assinatura);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(AssinaturaModel assinatura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _assinaturaRepositorio.Adicionar(assinatura);
                    TempData["MensagemSucesso"] = "Assinatura cadastrada com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(assinatura);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível importar sua assinatura, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(AssinaturaModel assinatura)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    _assinaturaRepositorio.Atualizar(assinatura);
                    TempData["MensagemSucesso"] = "Assinatura alterada com Sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", assinatura);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível importar sua assinatura, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _assinaturaRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Assinatura apagada com sucesso!";

                }
                else
                {
                    TempData["MensagemErro"] = $"Não foi possível importar sua assinatura, tente novamente.";

                }
                return RedirectToAction("Index");
            }

            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar sua assinatura, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
