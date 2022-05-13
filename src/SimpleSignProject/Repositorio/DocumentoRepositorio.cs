using SimpleSign.Data;
using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public class DocumentoRepositorio : IDocumentoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public DocumentoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public DocumentoModel Adicionar(DocumentoModel documento)
        {
            DocumentoModel DocumentoDb = ListarPorId(documento.Id);
            if (DocumentoDb == null)
            {
                throw new System.Exception("Houve um erro no upload do documento");
            }
            DocumentoDb.Nome = documento.Nome;
            DocumentoDb.Tipo = documento.Tipo;
            DocumentoDb.Descricao = documento.Descricao;
            DocumentoDb.DataEnvio = documento.DataEnvio;
            documento.DataCadastro = DateTime.Now;

            _bancoContext.Documentos.Add(documento);
            _bancoContext.SaveChanges();
            return documento;
        }

        public bool Apagar(int id)
        {
            DocumentoModel documentoDb = ListarPorId(id);
            if (documentoDb == null)
            {
                throw new System.Exception("Houve um erro na exlcusão do documento!");
            }
            _bancoContext.Documentos.Remove(documentoDb);
            _bancoContext.SaveChanges();

            return true;
        }

        public DocumentoModel Assinar(DocumentoModel documento)
        {
            DocumentoModel DocumentoDb = ListarPorId(documento.Id);
            if (DocumentoDb == null)
            {
                throw new System.Exception("Houve um erro na assinatura do documento");
            }
            DocumentoDb.DataAssinatura = documento.DataAssinatura;
            DocumentoDb.DataEnvio = documento.DataEnvio;
            DocumentoDb.Assinaturas = documento.Assinaturas;
            DocumentoDb.Usuarios = documento.Usuarios;

            _bancoContext.Documentos.Update(DocumentoDb);
            _bancoContext.SaveChanges();
            return DocumentoDb;
        }

        public bool Validade(DocumentoModel documento)
        {
            TimeSpan duracao = DateTime.Now.Subtract(documento.DataEnvio);
            if (duracao.TotalDays <= 7.0) //de acordo com a regra de negócio
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DocumentoModel> BuscarTodos()
        {
            return _bancoContext.Documentos.ToList();
        }

        public DocumentoModel ListarPorId(int id)
        {
            return _bancoContext.Documentos.FirstOrDefault(x => x.Id == id);
        }

        DocumentoModel IDocumentoRepositorio.Validade(DocumentoModel validade)
        {
            throw new NotImplementedException();
        }
    }
}
