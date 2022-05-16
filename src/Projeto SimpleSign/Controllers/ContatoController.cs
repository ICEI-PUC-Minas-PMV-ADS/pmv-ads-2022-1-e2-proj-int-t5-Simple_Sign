using Microsoft.AspNetCore.Mvc;
using SimpleSign.Filters;
using SimpleSign.Models;
using SimpleSign.Repositorio;

namespace SimpleSign.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = (IContatoRepositorio?)contatoRepositorio;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();

            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)

        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);

            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
               bool apagado = _contatoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso";

                }
                else
                {
                   TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato.";

                }
                return RedirectToAction("Index");
                }

            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato. Mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato. Tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }

           
        }

       
           [HttpPost]

        public IActionResult Atualizar(ContatoModel contato)
            
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", contato);
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato. Tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
        
    }
}
