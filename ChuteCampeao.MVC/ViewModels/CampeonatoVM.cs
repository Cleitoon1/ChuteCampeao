using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.ViewModels
{
    public class CampeonatoVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Campeonato")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Data de Início")]
        [Display(Name = "Data de Início")]
        [DataType(DataType.Date, ErrorMessage = "Informe a data corretamente")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Informe a Data de Termino")]
        [Display(Name = "Data de Termino")]
        [DataType(DataType.Date, ErrorMessage = "Informe a data corretamente")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "Informe a Situação")]
        [Display(Name = "Situação")]
        public int Situacao { get; set; }

        [Required(ErrorMessage = "Informe o Status")]
        [Display(Name = "Status")]
        public int Status { get; set; }

        public IEnumerable<SelectListItem> ListaStatus { get; set; }
    }
}