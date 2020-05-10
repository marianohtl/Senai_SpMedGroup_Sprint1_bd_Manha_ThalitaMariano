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
    public class GenerosController : Controller
    {

        private IGenerosRepository _generoRepository;

        public GenerosController()
        {
            _generoRepository = new GenerosRepository();
        }

        /// <summary>
        /// lista os gêneros
        /// </summary>
        /// <returns>retorna uma lista de gêneros</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_generoRepository.ListarGeneros());
        }
    }
}