using System.ComponentModel.DataAnnotations;

namespace RecodeAirline.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Nome { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Mensagem { get; set; }



    }
}
