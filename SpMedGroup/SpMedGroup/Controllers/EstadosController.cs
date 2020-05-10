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
    public class EstadosController : ControllerBase
    {
        private IEstadosRepository _estadosRepository;

        public EstadosController()
        {
            _estadosRepository = new EstadosRepository();
        }

        /// <summary>
        /// Lista os estados
        /// </summary>
        /// <returns>uma lista dos estados cadastrados</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_estadosRepository.BuscarEstados());
        }
    }
}