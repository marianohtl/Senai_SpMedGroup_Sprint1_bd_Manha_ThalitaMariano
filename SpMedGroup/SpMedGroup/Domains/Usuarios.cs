using System;
using System.Collections.Generic;

namespace SpMedGroup.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Consultas = new HashSet<Consultas>();
            Medicos = new HashSet<Medicos>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int IdGenero { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdEndereco { get; set; }

        public Enderecos IdEnderecoNavigation { get; set; }
        public Generos IdGeneroNavigation { get; set; }
        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
        public ICollection<Medicos> Medicos { get; set; }
    }
}
