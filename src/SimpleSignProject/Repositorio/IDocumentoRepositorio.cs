using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public interface IDocumentoRepositorio
    {
        List<DocumentoModel> BuscarTodos();
        DocumentoModel ListarPorId(int id);

        DocumentoModel Adicionar(DocumentoModel documento);
        DocumentoModel Assinar(DocumentoModel documento);
        DocumentoModel Validade(DocumentoModel validade);
        bool Apagar(int id);
    }
}
