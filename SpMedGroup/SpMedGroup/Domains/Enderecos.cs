using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Enderecos
    {
   

        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int IdCep { get; set; }

        public Ceps IdCepNavigation { get; set; }
    }
}
