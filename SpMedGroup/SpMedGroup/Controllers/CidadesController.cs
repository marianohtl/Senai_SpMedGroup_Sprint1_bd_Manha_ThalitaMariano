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
    public class CidadesController : Controller
    {
        /// <summary>
        /// Cria um objeto _cidadeRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        ICidadesRepository _cidadesRepository;


        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public CidadesController()
        {
            _cidadesRepository = new CidadesRepository();
        }

        /// <summary>
        /// Lista todos as cidades
        /// </summary>
        /// <returns>uma lista de cidades cadastrados no banco de dados</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Index()
        {
            return Ok(_cidadesRepository.ListarCidades());
        }


    }
}