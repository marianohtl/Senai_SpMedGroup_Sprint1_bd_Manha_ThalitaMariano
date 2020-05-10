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
    public class EnderecosController : ControllerBase
    {
        private IEnderecosRepository _enderecosRepository;

        public EnderecosController()
        {
            _enderecosRepository = new EnderecosRepository();
        }

        /// <summary>
        /// lista os endereços
        /// </summary>
        /// <returns>uma lista de endereços cadastrados no banco</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_enderecosRepository.BuscarEnderecos());
        }
    }
}