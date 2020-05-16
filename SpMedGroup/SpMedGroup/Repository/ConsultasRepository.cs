using Microsoft.EntityFrameworkCore;
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
            var consultas = context.Consultas.Include(x => x.IdUsuarioNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdClinicaNavigation).ThenInclude(x => x.IdEnderecoNavigation).Include(x => x.IdSituacaoNavigation).Include(x => x.IdPlanoSaudeNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdUsuarioNavigation).ToList();
            return consultas;
        }

        public Consultas BuscarConsulta(int consultaId)
        {
            var consulta = context.Consultas.Include(x => x.IdUsuarioNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdClinicaNavigation).ThenInclude(x => x.IdEnderecoNavigation).Include(x => x.IdSituacaoNavigation).Include(x => x.IdPlanoSaudeNavigation).Include(x => x.IdMedicoNavigation).ThenInclude(x => x.IdUsuarioNavigation).FirstOrDefault(c => c.IdConsulta == consultaId);
            return consulta;
        }

    }
}
