using System.ComponentModel.DataAnnotations;

namespace SimpleSign.Models
{
    public class ContatoModel 
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]
       
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o CPF do contato")]
       
        public string CPF { get; set; }
    }

}
      