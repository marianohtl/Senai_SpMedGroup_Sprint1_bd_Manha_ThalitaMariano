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
    public class MedicosController : ControllerBase
    {
        private IMedicosRepository _medicosRepository;

        public MedicosController()
        {
            _medicosRepository = new MedicosRepository();
        }

        /// <summary>
        /// Lista os médicos
        /// </summary>
        /// <returns>Retorna uma lista de médicos</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicosRepository.ListarMedicos());
        }
    }
}