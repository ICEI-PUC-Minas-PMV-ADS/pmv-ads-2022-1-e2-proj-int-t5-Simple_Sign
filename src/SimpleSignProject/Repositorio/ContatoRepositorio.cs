using SimpleSign.Data;
using SimpleSign.Models;

namespace SimpleSign.Repositorio
{

    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;


        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();

        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            // gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;

        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na tualização do contato!");
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.CPF = contato.CPF;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public bool Apagar(int id)
        {

            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na exlcusão contato!");
            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }

}