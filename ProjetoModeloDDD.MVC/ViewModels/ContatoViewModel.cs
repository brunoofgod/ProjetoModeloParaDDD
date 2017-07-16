using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BrunoofgodArch.MVC.ViewModels
{
    public class ContatoViewModel
    {
        [Key]
        public int ContatoId { get; set; }

        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string NomeDoVendedor { get; set; }

        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string NomeDaEmpresa { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string NomeDoContato { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SobreNomeDoContato { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int Telefone { get; set; }

        [Display(Name = "Data de validade")]
        public DateTime DataDeValidade { get; set; }

        [Display(Name = "Data de contato")]
        public DateTime DataDeContato { get; set; }
    }
}