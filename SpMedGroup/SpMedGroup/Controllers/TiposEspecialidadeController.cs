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
    public class TiposEspecialidadeController : Controller
    {
        private ITipoEspecialidadeRepository _tipoEspecialidadeRepository;

        public TiposEspecialidadeController()
        {
            _tipoEspecialidadeRepository = new TipoEspecialidadeRepository();
        }

        /// <summary>
        /// lista as especialidades que o médico pode ter
        /// </summary>
        /// <returns>uma lista com as especialidades cadastradas</returns
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_tipoEspecialidadeRepository.ListarTipoEspecialidade());
        }
    }
}