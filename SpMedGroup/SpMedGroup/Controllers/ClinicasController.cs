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
    public class ClinicasController : Controller
    {
        private IClinicasRepository _clinicaRepository;

        public ClinicasController() {
            _clinicaRepository = new ClinicasRepository();
        }
        
        /// <summary>
        /// Lista todas as clínicas
        /// </summary>
        /// <returns>Retorna uma lista de clínicas cadastradas</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_clinicaRepository.BuscarClinicas());
        }

    }
}