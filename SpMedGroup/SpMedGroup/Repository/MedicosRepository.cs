using Microsoft.EntityFrameworkCore;
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
            var medicos = context.Medicos.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdGeneroNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdTipoUsuarioNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdBairroNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdCidadeNavigation).ThenInclude(s => s.IdEstadoNavigation)
            .Include(x => x.IdClinicaNavigation).ToList();
            return medicos;
        }


        public Medicos BuscarMedico(int medicoId)
        {
            var medico = context.Medicos.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdGeneroNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdTipoUsuarioNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdBairroNavigation)
            .Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdCidadeNavigation).ThenInclude(s => s.IdEstadoNavigation)
            .Include(x => x.IdClinicaNavigation).FirstOrDefault(m => m.IdMedico == medicoId);
            return medico;
        }

    }
}