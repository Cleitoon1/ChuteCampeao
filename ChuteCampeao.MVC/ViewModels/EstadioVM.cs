using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChuteCampeao.MVC.ViewModels
{
    public class EstadioVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Estádio")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}