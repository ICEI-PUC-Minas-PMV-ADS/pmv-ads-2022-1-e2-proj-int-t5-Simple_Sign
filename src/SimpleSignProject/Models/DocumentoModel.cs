using System.ComponentModel.DataAnnotations;
using SimpleSign.Enums;

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
        public TipoDocEnum Tipo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAssinatura { get; set; }
        public bool Validade { get; set; }
        public int QtdeDevolutivas { get; set; }

        public List<AssinaturaModel> Assinaturas { get; set; } = new List<AssinaturaModel>();
        public List<UsuarioModel> Usuarios { get; set; } = new List<UsuarioModel>();
    }
}
