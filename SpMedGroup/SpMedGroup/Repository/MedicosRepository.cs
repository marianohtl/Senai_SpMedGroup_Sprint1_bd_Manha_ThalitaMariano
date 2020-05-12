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
            int id = 1;
            List<Medicos> medicos = new List<Medicos>();
            var dados = context.Medicos.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdGeneroNavigation);
            var dados2 = dados.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdTipoUsuarioNavigation);
            var dados3 = dados2.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdBairroNavigation);
            var dados4 = dados3.Include(x => x.IdUsuarioNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(q => q.IdCidadeNavigation).ThenInclude(s => s.IdEstadoNavigation);
            var dados5 = dados4.Include(x => x.IdClinicaNavigation).ThenInclude(y => y.IdEnderecoNavigation).ThenInclude(z => z.IdCepNavigation).ThenInclude(a => a.IdBairroNavigation);
            medicos = dados5.ToList();
            return medicos;
        }
    }
}
