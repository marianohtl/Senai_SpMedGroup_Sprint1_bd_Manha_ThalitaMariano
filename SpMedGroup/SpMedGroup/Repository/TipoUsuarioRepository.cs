using Microsoft.EntityFrameworkCore;
using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        ApiContext context = new ApiContext();


        /// <summary>
        /// Lista os tipos de usuário do sistema;
        /// </summary>
        /// <returns> Uma lista de tipos de usuários </returns>
        public List<TipoUsuario> ListarTiposUsuarios()
        {
            return context.TipoUsuario.ToList();
        }


    }
}
