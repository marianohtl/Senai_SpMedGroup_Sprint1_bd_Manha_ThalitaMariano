using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class EstadosRepository : IEstadosRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista os estados
        /// </summary>
        /// <returns>uma lista dos estados cadastrados</returns>
        public List<Estados> BuscarEstados()
        {
            return context.Estados.ToList();
        }
    }
}
