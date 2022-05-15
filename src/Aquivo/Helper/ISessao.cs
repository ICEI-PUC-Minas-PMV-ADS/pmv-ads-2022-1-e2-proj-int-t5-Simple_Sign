using SimpleSign.Models;

namespace SimpleSign.Helper
{
    public interface ISessao
    {

        void CriarSessaoDoUsuario(UsuarioModel usuario);

        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();
    }
}
