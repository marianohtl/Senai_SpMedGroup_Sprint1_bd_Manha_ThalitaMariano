using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class TipoEspecialidade
    {
        public TipoEspecialidade()
        {
            EspecialidadeMedico = new HashSet<EspecialidadeMedico>();
        }

        public int IdTipoEspecialidade { get; set; }
        public string NomeEspecialidade { get; set; }

        public ICollection<EspecialidadeMedico> EspecialidadeMedico { get; set; }
    }
}
