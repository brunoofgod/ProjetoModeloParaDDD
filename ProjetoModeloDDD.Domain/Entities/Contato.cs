using System;

namespace BrunoofgodArch.Domain.Entities
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public string NomeDoVendedor { get; set; }
        public string NomeDaEmpresa { get; set; }
        public string NomeDoContato { get; set; }
        public string SobreNomeDoContato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataDeContato { get; set; }
        public DateTime? DataDeValidade { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}