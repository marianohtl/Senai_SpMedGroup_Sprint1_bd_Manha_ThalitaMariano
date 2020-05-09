using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Bairros
    {
        public Bairros()
        {
            Ceps = new HashSet<Ceps>();
        }

        public int IdBairro { get; set; }
        public string Bairro { get; set; }

        public ICollection<Ceps> Ceps { get; set; }
    }
}
