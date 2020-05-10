using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class GenerosRepository : IGenerosRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista os gêneros
        /// </summary>
        /// <returns>retorna uma lista de gêneros</returns>
        public List<Generos> ListarGeneros()
        {
            return context.Generos.ToList();
        }
    }
}
