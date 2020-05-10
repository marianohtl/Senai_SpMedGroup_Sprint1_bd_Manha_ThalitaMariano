using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class PlanoSaudeRepository : IPlanoSaudeRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista os planos de saude
        /// </summary>
        /// <returns>uma lista com os planos de saúde cadastrados</returns>
        public List<PlanoSaude> ListarPlanoSaude()
        {
            return context.PlanoSaude.ToList();
        }
    }
}
