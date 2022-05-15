using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public interface IUsuarioRepositorio
    {
         
        UsuarioModel BuscarPorLogin(string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id);

        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
