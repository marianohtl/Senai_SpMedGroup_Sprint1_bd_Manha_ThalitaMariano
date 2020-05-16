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
    public class EspecialidadeMedicoController : Controller
    {

        private IEspecialidadeMedicoRepository _especialidadeMedicoRepository;

        public EspecialidadeMedicoController()
        {
            _especialidadeMedicoRepository = new EspecialidadeMedicoRepository();
        }

        /// <summary>
        /// Lista as especialidades dos médicos
        /// </summary>
        /// <returns>Uma lista de especialidades que os médicos podem ter</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok(_especialidadeMedicoRepository.BuscarTodasEspecialidadeMedico());
        }

        [HttpGet("{medicoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetEspecialidade(int medicoId) {
            return Ok(_especialidadeMedicoRepository.BuscarEspecialidadeMedico(medicoId));
        }
    }
}