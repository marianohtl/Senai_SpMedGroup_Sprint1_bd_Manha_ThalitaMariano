using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class EspecialidadeMedico
    {
        public int IdEspecialidadeMedico { get; set; }
        public int IdTipoEspecialidade { get; set; }
        public int IdMedico { get; set; }

        public Medicos IdMedicoNavigation { get; set; }
        public TipoEspecialidade IdTipoEspecialidadeNavigation { get; set; }
    }
}
