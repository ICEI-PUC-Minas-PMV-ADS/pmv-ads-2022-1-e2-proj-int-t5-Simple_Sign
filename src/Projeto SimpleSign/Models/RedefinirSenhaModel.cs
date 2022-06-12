

using System.ComponentModel.DataAnnotations;

namespace SimpleSign.Models
{
    
    public class RedefinirSenhaModel 
    {

        
        [Required(ErrorMessage = "Digite seu CPF")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite seu e-mail")]
        
        public string Email { get; set; }
    }
}

