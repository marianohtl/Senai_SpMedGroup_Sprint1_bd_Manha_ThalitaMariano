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
    public class CepController : ControllerBase
    {

        /// <summary>
        /// Cria um objeto _cepRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private ICepsRepository _cepsRepository;


        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public CepController() {
            _cepsRepository = new CepsRepository();
        }

        /// <summary>
        /// Lista todos os ceps 
        /// </summary>
        /// <returns>uma lista de ceps cadastrados no banco de dados</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_cepsRepository.BuscarCeps());
        }
    }
}