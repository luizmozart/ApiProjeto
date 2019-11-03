using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProjeto.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : Controller
    {
        private IDepartamentoService _departamentoBusiness;

        public DepartamentoController(IDepartamentoService departamentoBusiness)
        {
            _departamentoBusiness = departamentoBusiness;
        }

        /// <summary>
        /// Lista todos os departamentos de um cliente.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     Get /Departamento
        ///
        /// </remarks>
        /// <param name="clientId"></param>
        /// <returns>Todos os Departamentos</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpGet("{clienteId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll(int clienteId)
        {

            return Ok(await _departamentoBusiness.GetDepartamentoByEmpresa(clienteId));
        }

        [HttpGet("{clienteId:int}/{codigoDepartamento:int}")]
        [Route("api/[controller]/clienteId/codigoDepartamento")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int clienteId, int codigoDepartamento)
        {
            return Ok(await _departamentoBusiness.GetDepartamentoByCod(clienteId, codigoDepartamento));
        }
    }
}