using Microsoft.EntityFrameworkCore;
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

            List<Usuarios> user = new List<Usuarios>();
            var dados = context.Usuarios.Include(t => t.IdTipoUsuarioNavigation).Include(g => g.IdGeneroNavigation).Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(b => b.IdBairroNavigation);
            user = dados.Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(b => b.IdCidadeNavigation).ThenInclude(e => e.IdEstadoNavigation).ToList();
            return user;
        }
    }
}
