using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public interface IAssinaturaRepositorio
    {
        List<AssinaturaModel> BuscarTodos();
        AssinaturaModel ListarPorId(int id);

        AssinaturaModel Adicionar(AssinaturaModel assinatura);
        AssinaturaModel Atualizar(AssinaturaModel assinatura);
        bool Apagar(int id);
    }
}
