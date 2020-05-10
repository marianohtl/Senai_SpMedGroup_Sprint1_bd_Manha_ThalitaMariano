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
            return context.Enderecos.ToList();
        }

    }
}
