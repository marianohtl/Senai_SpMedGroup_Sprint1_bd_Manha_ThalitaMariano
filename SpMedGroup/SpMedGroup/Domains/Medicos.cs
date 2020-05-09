using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Medicos
    {
        public Medicos()
        {
            Consultas = new HashSet<Consultas>();
            EspecialidadeMedico = new HashSet<EspecialidadeMedico>();
        }

        public int IdMedico { get; set; }
        public string Crm { get; set; }
        public int IdUsuario { get; set; }
        public int IdClinica { get; set; }

        public Clinicas IdClinicaNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
        public ICollection<EspecialidadeMedico> EspecialidadeMedico { get; set; }
    }
}
