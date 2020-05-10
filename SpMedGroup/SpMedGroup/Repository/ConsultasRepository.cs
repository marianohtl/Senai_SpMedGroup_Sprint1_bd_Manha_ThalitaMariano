using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class ConsultasRepository : IConsultasRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista as consultas
        /// </summary>
        /// <returns>uma lista de consultas cadastrada</returns>
        public List<Consultas> BuscarConsultas()
        {
            return context.Consultas.ToList();
        }
    }
}
