using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class CepsRepository : ICepsRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista todos os ceps 
        /// </summary>
        /// <returns>uma lista de ceps cadastrados no banco de dados</returns>
        public List<Ceps> BuscarCeps()
        {
            return context.Ceps.ToList();
        }
    }


}
