using System;
using System.ComponentModel.DataAnnotations;

namespace ChuteCampeao.MVC.ViewModels
{
    public class TimeVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome Completo do time")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Informe o Nome Conhecido do time")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string NomeConhecido { get; set; }

        [Required(ErrorMessage = "Informe o Apelido do time")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Informe a data de fundação")]
        public DateTime DataFundacao { get; set; }
    }
}