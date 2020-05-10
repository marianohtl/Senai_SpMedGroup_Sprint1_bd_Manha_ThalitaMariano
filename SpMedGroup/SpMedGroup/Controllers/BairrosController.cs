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
    public class BairrosController : Controller
    {
        /// <summary>
        /// Cria um objeto _tipoUsuarioRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private IBairrosRepository _bairroRepository;

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public BairrosController()
        {
            _bairroRepository = new BairrosRepository();
        }

        /// <summary>
        /// Lista todos os bairros
        /// </summary>
        /// <returns>Uma lista de bairros cadastrados e o status code ok</returns>
        /// <response code="200">Resquisição bem sucedida</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_bairroRepository.ListarBairros());
        }
    }
}