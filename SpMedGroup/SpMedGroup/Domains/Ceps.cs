using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Ceps
    {

        public int IdCep { get; set; }
        public string Cep { get; set; }
        public int IdBairro { get; set; }
        public int IdCidade { get; set; }

        public Bairros IdBairroNavigation { get; set; }
        public Cidades IdCidadeNavigation { get; set; }
   
    }
}
