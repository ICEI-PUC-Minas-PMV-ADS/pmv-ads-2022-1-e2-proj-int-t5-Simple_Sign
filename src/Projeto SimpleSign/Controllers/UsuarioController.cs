using Microsoft.AspNetCore.Mvc;
using SimpleSign.Enums;
using SimpleSign.Filters;
using SimpleSign.Models;
using SimpleSign.Repositorio;
using SimpleSign.Services;
using System.Diagnostics;
using System.Text;

namespace SimpleSign.Controllers
{
    
    public class UsuarioController : Controller
    {
        private  IUsuarioRepositorio _usuarioRepositorio;
        
       

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio )
        {
            _usuarioRepositorio = usuarioRepositorio;
           
        }

        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();

            return View(usuarios);
        }
        public IActionResult Criar()
        {

           
            return View();
        }


        public IActionResult Editar(int id)

        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }



        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);

            return View(usuario);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario apagado com sucesso";

                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu Usuario.";

                }
                return RedirectToAction("Index");
            }

            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu Usuario. Mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public   IActionResult Criar(UsuarioModel usuario)

        {
            try
            {
                if (ModelState.IsValid)
                {
                  
                    
                   
                    usuario = _usuarioRepositorio.Adicionar(usuario);
                    Suporte objsup = new Suporte();
                    string corpoEmail = "Olá, " + usuario.Nome + " Bem vindo ao sistema! Cadastro realizado com sucesso!" +
                        " Agora você já está pronto para utilizar suas assinaturas.";
                    objsup.EnviarEmail("Bem Vindo Ao SimpleSign!", usuario.Email, corpoEmail);
                    TempData["MensagemSucesso"] = $"Cadastro realizado com sucesso! Enviamos um email de confirmação!";
                    return RedirectToAction("Index", "Login");


                }

                else
                {
                    Suporte objsup = new Suporte();
                    string corpoEmail = "Olá" + usuario.Nome + "Bem vindo ao sistema. Cadastro realizado com sucesso!";
                    objsup.EnviarEmail("Bem Vindo Ao SimpleSign", usuario.Email, corpoEmail);
                    TempData["MensagemSucesso"] = $"Cadastro realizado com sucesso! Enviamos um email de confirmação!";


                    return RedirectToAction("Index", "Login");
                }



            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o usuario. Tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]

        public IActionResult Atualizar(UsuarioSemSenhaModel usuarioSemSenhaModel)

        {
            try
            {
                UsuarioModel usuario = null;
                if (ModelState.IsValid)
                {

                   usuario = new UsuarioModel()
                    {

                        Id = usuarioSemSenhaModel.Id,
                        Nome = usuarioSemSenhaModel.Nome,
                        Login = usuarioSemSenhaModel.Login,
                        Email = usuarioSemSenhaModel.Email,
                        
                       Perfil = usuarioSemSenhaModel.Perfil


                    };

                   usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario alterado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu usuario. Tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
