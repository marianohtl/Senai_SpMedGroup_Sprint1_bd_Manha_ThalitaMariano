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
    public class PlanoSaudeController : ControllerBase
    {

        private IPlanoSaudeRepository _planoSaudeRepository;

        public PlanoSaudeController()
        {
            _planoSaudeRepository = new PlanoSaudeRepository();
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_planoSaudeRepository.ListarPlanoSaude());
        }
    }
}