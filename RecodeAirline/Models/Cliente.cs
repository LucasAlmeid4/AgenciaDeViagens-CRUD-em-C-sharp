using System.ComponentModel.DataAnnotations;

namespace RecodeAirline.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Nome { get; set;}

        [Required]
        [StringLength(12, ErrorMessage = "Responda apenas com M/F")]
        public string Sexo { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Excedeu o número de caracteres!")]
        public string CPF { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Idade { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Apenas dois digitos!")]
        public string UF { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Endereco { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Excedeu o número de caracteres!")]
        public string Destino { get; set; }





    }
}
