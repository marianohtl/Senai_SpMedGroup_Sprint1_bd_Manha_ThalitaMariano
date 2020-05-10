using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class MedicosRepository : IMedicosRepository
    {
        ApiContext context = new ApiContext();


        /// <summary>
        /// Lista os médicos
        /// </summary>
        /// <returns>Retorna uma lista de médicos</returns>
        public List<Medicos> ListarMedicos()
        {
            return context.Medicos.ToList();
        }
    }
}
