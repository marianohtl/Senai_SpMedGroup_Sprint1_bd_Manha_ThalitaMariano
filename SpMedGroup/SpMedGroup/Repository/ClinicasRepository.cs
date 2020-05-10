using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class ClinicasRepository : IClinicasRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista as Clinicas
        /// </summary>
        /// <returns>uma lista de clínicas</returns>
        public List<Clinicas> BuscarClinicas()
        {
            return context.Clinicas.ToList();
        }
    }
}
