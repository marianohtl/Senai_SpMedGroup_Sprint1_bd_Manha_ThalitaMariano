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
    public class ConsultasController : Controller
    {
        private IConsultasRepository _consultaRepository;


        public ConsultasController()
        {
            _consultaRepository = new ConsultasRepository();
        }

        /// <summary>
        /// Lista as consultas
        /// </summary>
        /// <returns>uma lista de consultas cadastrada</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_consultaRepository.BuscarConsultas());
        }


    }
}