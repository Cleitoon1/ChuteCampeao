using ChuteCampeao.Domain.Entites;
using ChuteCampeao.MVC.Helpers.Anotacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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

        [Required(ErrorMessage = "Informe o Nome Abreviado do time")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [Display(Name = "Nome Abreviado")]
        public string NomeAbreviado { get; set; }

        [Required(ErrorMessage = "Informe o Apelido do time")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Required(ErrorMessage = "Informe a Data de Fundação")]
        [Display(Name = "Data de Fundação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [ValidateDateRangeFormat("01/01/1850", "now", "dd/MM/yyyy", ErrorMessage = "Informe um data válida")]
        public string DataFundacao { get; set; }

        [Required(ErrorMessage = "Informe o Estádio")]
        [Display(Name = "Estádio")]
        public int EstadioId { get; set; }

        [Display(Name = "Estádio")]
        public Estadio Estadio { get; set; }

        [Required(ErrorMessage = "Informe o Status")]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        public IEnumerable<SelectListItem> LstStatus { get; set; }

        public IEnumerable<SelectListItem> ListaEstadios { get; set; }
    }
}