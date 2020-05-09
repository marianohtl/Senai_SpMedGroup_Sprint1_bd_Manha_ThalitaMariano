using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Consultas
    {
        public int IdConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public decimal? ValorConsulta { get; set; }
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }
        public int IdPlanoSaude { get; set; }
        public int IdSituacao { get; set; }
        public int IdMedico { get; set; }

        public Medicos IdMedicoNavigation { get; set; }
        public PlanoSaude IdPlanoSaudeNavigation { get; set; }
        public Situacoes IdSituacaoNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
