using Microsoft.EntityFrameworkCore;
using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class EnderecosRepository : IEnderecosRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista os endereços
        /// </summary>
        /// <returns>uma lista de endereços cadastrados no banco</returns>
        public List<Enderecos> BuscarEnderecos()
        {
            List<Enderecos> enderecos = new List<Enderecos>();
            var dados = context.Enderecos.Include(c => c.IdCepNavigation).ThenInclude(b => b.IdBairroNavigation);
            enderecos = dados.Include(c => c.IdCepNavigation).ThenInclude(c => c.IdCidadeNavigation).ThenInclude(e => e.IdEstadoNavigation).ToList();
            return enderecos;
        }

    }
}
