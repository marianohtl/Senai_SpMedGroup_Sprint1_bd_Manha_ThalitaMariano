using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class EspecialidadeMedicoRepository : IEspecialidadeMedicoRepository
    {
        ApiContext context = new ApiContext();
 
        /// <summary>
        /// Lista as especialidades dos médicos
        /// </summary>
        /// <returns>Uma lista de especialidades que os médicos podem ter</returns>
        public List<EspecialidadeMedico> BuscarEspecialidadeMedico()
        {
            return context.EspecialidadeMedico.ToList();
        }

    }
}
