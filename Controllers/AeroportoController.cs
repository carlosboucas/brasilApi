using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AeroportoController : ControllerBase
    {
        public readonly IAeroportoService _aeroportoService;

        public AeroportoController(IAeroportoService aeroportoService)
        {
            _aeroportoService = aeroportoService;
        }

        [HttpGet("busca/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodos()
        {
            var response = await _aeroportoService.BuscarTodosAeroportos();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }


        [HttpGet("busca/{codigoIcao}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Buscar(string codigoIcao)
        {
            var response = await _aeroportoService.BuscarAeroporto(codigoIcao);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}