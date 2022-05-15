using System.ComponentModel.DataAnnotations;

namespace SimpleSign.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite um CPF")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
