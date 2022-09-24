using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace API_Livros.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail do usuário")]

        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]

        public string senha { get; set; }
      
    }
}

