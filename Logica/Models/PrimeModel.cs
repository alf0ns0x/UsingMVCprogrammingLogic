using System.ComponentModel.DataAnnotations;


namespace Logica.Models
{
    public class PrimeModel
    {
        [Required(ErrorMessage = "Es obligatorio introducir un numero.")]
        [Range(2, int.MaxValue, ErrorMessage = "El número debe ser mayor o igual a 2.")]
        public int Number { get; set; } 
    }
}
