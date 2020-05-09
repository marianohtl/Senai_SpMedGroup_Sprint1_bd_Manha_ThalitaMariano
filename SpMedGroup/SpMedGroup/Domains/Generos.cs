using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Generos
    {
        public Generos()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdGenero { get; set; }
        public string Genero { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
