using Microsoft.AspNetCore.Mvc;
using SimpleSign.Models;
using SimpleSign.Repositorio;
using SimpleSign.Helper;
using SimpleSign.Services;

namespace SimpleSign.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
            
        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {

            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }


        public IActionResult Index()
        {

            //Se o usuario estiver logado redirecionar para a Home

            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }
            public IActionResult Ir()
            {
            return View("Principal", "Login");
            }
        public IActionResult RedefinirSenha()
        {
            return View();
        }
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index" , "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);




                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))

                        {

                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha do usuario é inválida. Tente novamente!";

                    }

                    TempData["MensagemErro"] = $"Usuario e/ou senha inválido(s). Por favor, tente novamente!";

                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente. Mais detalhes do erro: {erro.Message}";

                return RedirectToAction("Index");

            }
        }
            [HttpPost]
            public IActionResult EnviarLinkParaRedefinirSenha(RedefinirSenhaModel redefinirSenhaModel)
            {
                try
                {

                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorEmailELogin(redefinirSenhaModel.Email, redefinirSenhaModel.Login);

                    if (usuario != null)
                    {
                        string novaSenha = usuario.GerarNovaSenha();
                        _usuarioRepositorio.Atualizar(usuario);
                        Suporte objsup = new Suporte();
                        string corpoEmail = $"Olá  Sua nova senha  é : {novaSenha}  "  + 
                            " Bem vindo ao sistema!" + usuario.Nome + 
                            "Senha Alterada com sucesso!" +
                           " Agora você já pode voltar a utilizar suas assinaturas.";
                        
                        objsup.EnviarEmail("Recuperação de senha SimpleSign!", usuario.Email, corpoEmail);

                        TempData["MensagemSucesso"] = $"Enviamos para seu e-mail cadastrado uma nova senha.";
                        return RedirectToAction("Index", "Login");

                       

                    }
                   

                    }
                TempData["MensagemErro"] = $"Não conseguimos redefinir sua senha. Por favor, verifique os dados informados.";

                return View("Index");
                }
                catch (Exception erro)
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos redefinir sua senha, tente novamante, detalhe do erro: {erro.Message}";
                    return RedirectToAction("Index");
                }


            }
        
       
       
    }
}


