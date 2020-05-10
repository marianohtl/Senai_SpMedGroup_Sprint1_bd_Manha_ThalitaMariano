using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class TipoEspecialidadeRepository : ITipoEspecialidadeRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista as especialidades que o médico pode ter
        /// </summary>
        /// <returns>uma lista com as especialidades cadastradas</returns
        public List<TipoEspecialidade> ListarTipoEspecialidade()
        {
            return context.TipoEspecialidade.ToList();
        }
    }
}
