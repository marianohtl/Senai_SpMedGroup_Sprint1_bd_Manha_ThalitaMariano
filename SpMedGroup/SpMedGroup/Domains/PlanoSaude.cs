using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class PlanoSaude
    {
        public PlanoSaude()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int IdPlanoSaude { get; set; }
        public string NomePlano { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
