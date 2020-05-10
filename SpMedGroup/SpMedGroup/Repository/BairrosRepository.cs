using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class BairrosRepository : IBairrosRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista todos os bairros
        /// </summary>
        /// <returns>Uma lista de bairros cadastrados e o status code ok</returns>
        /// <response code="200">Resquisição bem sucedida</response>
        public List<Bairros> ListarBairros() {
            return context.Bairros.ToList();
        }
    }
}
