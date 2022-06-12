using SimpleSign.Data;
using SimpleSign.Models;

namespace SimpleSign.Repositorio
{

    public class UsuarioRepositorio : IUsuarioRepositorio
    {


        private readonly BancoContent _bancoContext;


        public UsuarioRepositorio(BancoContent bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public UsuarioModel BuscarPorLogin(string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());

        }
        public UsuarioModel BuscarPorEmailELogin(string login, string email)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper() && x.Login.ToUpper() == login.ToUpper());

        }

        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();

        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            // gravar no banco de dados

            usuario.DataCadastro = DateTime.Now;
            usuario.SetSenhaHash();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;

        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel UsuarioDB = ListarPorId(usuario.Id);
            if (UsuarioDB == null) throw new System.Exception("Houve um erro na tualização do Usuario!");
            UsuarioDB.Nome = usuario.Nome;            
            UsuarioDB.Login = usuario.Login;
            UsuarioDB.Email = usuario.Email;
            UsuarioDB.Perfil = usuario.Perfil;
            UsuarioDB.Senha = usuario.Senha;
            UsuarioDB.DataAtualizacao = DateTime.Now;
            
            _bancoContext.Usuarios.Update(UsuarioDB);
            _bancoContext.SaveChanges();
            return UsuarioDB;
        }

        public bool Apagar(int id)
        {

            UsuarioModel UsuarioDB = ListarPorId(id);
            if (UsuarioDB == null) throw new System.Exception("Houve um erro na exlcusão do usuario!");
            _bancoContext.Usuarios.Remove(UsuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

     
    }

}