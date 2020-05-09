using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Cidades
    {
        public Cidades()
        {
            Ceps = new HashSet<Ceps>();
        }

        public int IdCidade { get; set; }
        public string Cidade { get; set; }
        public int IdEstado { get; set; }

        public Estados IdEstadoNavigation { get; set; }
        public ICollection<Ceps> Ceps { get; set; }
    }
}
