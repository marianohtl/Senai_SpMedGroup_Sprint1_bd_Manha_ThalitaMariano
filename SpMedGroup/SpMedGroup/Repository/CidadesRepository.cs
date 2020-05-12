using Microsoft.EntityFrameworkCore;
using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class CidadesRepository : ICidadesRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// Lista todos as cidades 
        /// </summary>
        /// <returns>uma lista de cidades cadastrados no banco de dados</returns>
        public List<Cidades> ListarCidades()
        {
             List<Cidades> cidades = new List<Cidades>(context.Cidades.Include(c => c.IdEstadoNavigation).ToList());
             return cidades;
        }
    }



}
