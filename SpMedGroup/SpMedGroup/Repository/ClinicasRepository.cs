using Microsoft.EntityFrameworkCore;
using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class ClinicasRepository : IClinicasRepository
    {
        ApiContext context = new ApiContext();
        /// <summary>
        /// Lista as Clinicas
        /// </summary>
        /// <returns>uma lista de clínicas</returns>
        public List<Clinicas> BuscarClinicas()
        {
            List<Clinicas> clinicas = new List<Clinicas>();

            var dados = context.Clinicas.Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(b => b.IdBairroNavigation);
            clinicas = dados.Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(cd => cd.IdCidadeNavigation).ThenInclude(e => e.IdEstadoNavigation).ToList();
            return clinicas;
        }

        public Clinicas BuscarClinica(int clinicaId)
        {
            var clinicas = context.Clinicas.Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(b => b.IdBairroNavigation).Include(e => e.IdEnderecoNavigation).ThenInclude(c => c.IdCepNavigation).ThenInclude(cd => cd.IdCidadeNavigation).ThenInclude(e => e.IdEstadoNavigation).FirstOrDefault(c => c.IdClinica == clinicaId);
            return clinicas;
        }

    }
}
