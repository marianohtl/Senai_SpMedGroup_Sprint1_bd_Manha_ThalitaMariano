using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Situacoes
    {
        public Situacoes()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int IdSituacao { get; set; }
        public string Situacao { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
