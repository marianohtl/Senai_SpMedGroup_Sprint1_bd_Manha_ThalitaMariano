using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista os usuários
        /// </summary>
        /// <returns>uma lista com os usuários cadastrados</returns
        public List<Usuarios> ListarUsuarios()
        {
            return context.Usuarios.ToList();
        }
    }
}
