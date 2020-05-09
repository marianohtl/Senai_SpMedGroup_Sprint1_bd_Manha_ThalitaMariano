using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Clinicas
    {
        public Clinicas()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int IdClinica { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public TimeSpan HorarioAbertura { get; set; }
        public TimeSpan HorarioFechamento { get; set; }
        public int IdEndereco { get; set; }

        public Enderecos IdEnderecoNavigation { get; set; }
        public ICollection<Medicos> Medicos { get; set; }
    }
}
