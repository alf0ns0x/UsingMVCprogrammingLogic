using System.ComponentModel.DataAnnotations;

namespace Logica.Models
{
    public class PalindromeModel
    {
        [Required(ErrorMessage = "Intruduce una palabras o frase.")]
        public string Word { get; set; }   
    }
}
