using System.ComponentModel.DataAnnotations;

namespace SimpleSign.Models
{
    public class DocumentoModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Tipo de documento")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public string Tipo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAssinatura { get; set; }
        public bool StatusDoc { get; set; }
        public int QtdeDevolutivas { get; set; }

        public List<AssinaturaModel> Assinaturas { get; set; } = new List<AssinaturaModel>();
        public List<UsuarioModel> Usuarios { get; set; } = new List<UsuarioModel>();

        public enum TipoDocumento
        {
            Imovel,
            Veiculo,
            Produto,
            Servico
        }

        public DocumentoModel(int id, string nome, string tipo, string descricao)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
        }

        public void AddAssinatura(AssinaturaModel assinatura)
        {
            Assinaturas.Add(assinatura);
        }

        public void AddUsuario(UsuarioModel usuario)
        {
            Usuarios.Add(usuario);
        }

        public static bool Validade(DateTime DataEnvio)
        {
            TimeSpan duracao = DateTime.Now.Subtract(DataEnvio);
            if (duracao.TotalDays <= 7.0) //de acordo com a regra de negócio
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
