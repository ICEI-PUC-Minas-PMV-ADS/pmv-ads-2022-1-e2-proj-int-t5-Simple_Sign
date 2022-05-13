using SimpleSign.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace SimpleSign.Models
{
    public class AssinaturaModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o usuário!")]
        public string Usuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }    
}
