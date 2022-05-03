using SimpleSign.Data;
using SimpleSign.Models;

namespace SimpleSign.Repositorio
{

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;


        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

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
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;

        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel UsuarioDB = ListarPorId(usuario.Id);
            if (UsuarioDB == null) throw new System.Exception("Houve um erro na tualização do Usuario!");
            UsuarioDB.Nome = usuario.Nome;
            UsuarioDB.Email = usuario.Email;
            UsuarioDB.Login = usuario.Login;
            UsuarioDB.Perfil = usuario.Perfil;
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