using SpMedGroup.Domains;
using SpMedGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.Repository
{
    public class SituacoesRepository : ISituacoesRepository
    {
        ApiContext context = new ApiContext();

        /// <summary>
        /// lista a situação da consulta
        /// </summary>
        /// <returns>uma lista de situações da consulta</returns
        public List<Situacoes> ListarSituacoes()
        {
            return context.Situacoes.ToList();
        }
    }
}
