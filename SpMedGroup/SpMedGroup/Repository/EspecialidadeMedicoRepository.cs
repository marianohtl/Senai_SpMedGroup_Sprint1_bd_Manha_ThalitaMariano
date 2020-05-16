using Microsoft.EntityFrameworkCore;
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
        public List<EspecialidadeMedico> BuscarTodasEspecialidadeMedico()
        {
            return context.EspecialidadeMedico.Include(x => x.IdTipoEspecialidadeNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdUsuarioNavigation).Include(x => x.IdTipoEspecialidadeNavigation).ToList();
        }
        
        public List<EspecialidadeMedico> BuscarEspecialidadeMedico(int medicoId)
        {
            var especialidadeMedico = context.EspecialidadeMedico.Where(e => e.IdMedico == medicoId).Include(x => x.IdTipoEspecialidadeNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdUsuarioNavigation).Include(x => x.IdTipoEspecialidadeNavigation).ToList();
            return especialidadeMedico; 
        }   

    }
}
