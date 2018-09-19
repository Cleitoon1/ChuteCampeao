using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [Display(Name = "Apelido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O Apelido deve ter entre {1} e {0} caracteres")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Informe a Data de Inauguração do Estádio")]
        [Display(Name = "Data de Inauguração")]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida")]
        public DateTime DataInauguracao { get; set; }

        [Required(ErrorMessage = "Informe a Capacidade do Estádio")]
        [Display(Name = "Capacidade")]
        public int Capacidade { get; set; }

        [Required(ErrorMessage = "Informe o Status")]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        public IEnumerable<SelectListItem> LstStatus { get; set; }
    }
}