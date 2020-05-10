using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedGroup.Interfaces;
using SpMedGroup.Repository;

namespace SpMedGroup.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class SituacoesController : ControllerBase
    {
        private ISituacoesRepository _situacoesSaudeRepository;

        public SituacoesController()
        {
            _situacoesSaudeRepository = new SituacoesRepository();
        }

        /// <summary>
        /// lista a situação da consulta
        /// </summary>
        /// <returns>uma lista de situações da consulta</returns
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_situacoesSaudeRepository.ListarSituacoes());
        }
    }
}