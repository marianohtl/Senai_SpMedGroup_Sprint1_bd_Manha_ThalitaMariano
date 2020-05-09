using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Estados
    {
        public Estados()
        {
            Cidades = new HashSet<Cidades>();
        }

        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string Capital { get; set; }
        public string Sigla { get; set; }

        public ICollection<Cidades> Cidades { get; set; }
    }
}
