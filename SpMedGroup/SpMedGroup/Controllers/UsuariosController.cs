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
    public class UsuariosController : ControllerBase
    {

        private IUsuariosRepository _usuariosRepository;

        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        /// <summary>
        /// lista os usuários
        /// </summary>
        /// <returns>uma lista com os usuários cadastrados</returns

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_usuariosRepository.ListarUsuarios());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{usuarioId}")]
        public IActionResult GetUser(int usuarioId)
        {
            return Ok(_usuariosRepository.BuscarUsuario(usuarioId));
        }


    }
}