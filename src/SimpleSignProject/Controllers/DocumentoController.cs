using Microsoft.AspNetCore.Mvc;
using SimpleSign.Models;
using SimpleSign.Data;
using SimpleSign.Repositorio;

namespace SimpleSign.Controllers
{
    public class DocumentoController : Controller
    {
        private readonly IDocumentoRepositorio _documentoRepositorio;
        private readonly BancoContext _bancoContext;
        public DocumentoController(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public DocumentoController(IDocumentoRepositorio documentoRepositorio)
        {
            _documentoRepositorio = (IDocumentoRepositorio)documentoRepositorio;
        }
        public IActionResult Index()
        {
            List<DocumentoModel> documentos = _documentoRepositorio.BuscarTodos();

            return View(documentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)

        {
            DocumentoModel documento = _documentoRepositorio.ListarPorId(id);
            return View(documento);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            DocumentoModel documento = _documentoRepositorio.ListarPorId(id);

            return View(documento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(DocumentoModel documento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentoRepositorio.Adicionar(documento);
                    TempData["MensagemSucesso"] = "Documento cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(documento);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível importar seu documento, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(DocumentoModel documento)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    _documentoRepositorio.Atualizar(documento);
                    TempData["MensagemSucesso"] = "Contato alterado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", documento);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível importar seu documento, tente novamente. Detalhe do erro: {erro.Message}";
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
                bool apagado = _documentoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Documento apagado com sucesso!";

                }
                else
                {
                    TempData["MensagemErro"] = $"Não foi possível apagar seu documento, tente novamente.";

                }
                return RedirectToAction("Index");
            }

            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar seu documento, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
