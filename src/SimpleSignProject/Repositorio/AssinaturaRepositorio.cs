using SimpleSign.Data;
using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public class AssinaturaRepositorio : IAssinaturaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AssinaturaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public AssinaturaModel Adicionar(AssinaturaModel assinatura)
        {
            AssinaturaModel AssinaturaDb = ListarPorId(assinatura.Id);
            if (AssinaturaDb == null)
            {
                throw new System.Exception("Houve um erro no upload do documento");
            }
            AssinaturaDb.Usuario = assinatura.Usuario;
            AssinaturaDb.DataCadastro = DateTime.Now;            

            _bancoContext.Assinaturas.Add(assinatura);
            _bancoContext.SaveChanges();
            return assinatura;
        }

        public bool Apagar(int id)
        {
            AssinaturaModel assinaturaDb = ListarPorId(id);
            if (assinaturaDb == null)
            {
                throw new System.Exception("Houve um erro na exlcusão da assinatura!");
            }
            _bancoContext.Assinaturas.Remove(assinaturaDb);
            _bancoContext.SaveChanges();

            return true;
        }

        public AssinaturaModel Atualizar(AssinaturaModel assinatura)
        {
            AssinaturaModel AssinaturaDb = ListarPorId(assinatura.Id);
            if (AssinaturaDb == null)
            {
                throw new System.Exception("Houve um erro no upload do documento");
            }
            AssinaturaDb.Usuario = assinatura.Usuario;
            AssinaturaDb.DataAtualizacao = DateTime.Now;

            _bancoContext.Assinaturas.Update(AssinaturaDb);
            _bancoContext.SaveChanges();
            return AssinaturaDb;
        }

        public List<AssinaturaModel> BuscarTodos()
        {
            return _bancoContext.Assinaturas.ToList();
        }

        public AssinaturaModel ListarPorId(int id)
        {
            return _bancoContext.Assinaturas.FirstOrDefault(x => x.Id == id);
        }
    }
}
