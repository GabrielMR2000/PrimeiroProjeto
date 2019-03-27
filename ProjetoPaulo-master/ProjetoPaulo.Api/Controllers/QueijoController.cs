using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Service.Interface;

namespace ProjetoPaulo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueijoController : ControllerBase
    {
        private readonly IQueijoService _QueijoaService;

        public QueijoController(IQueijoService QueijoService)
        {
            _QueijoaService = QueijoService;
        }

        [HttpGet]
        public IActionResult All()
        {
            try
            {
                List<Queijo> All = _QueijoaService.BuscarTodosOsQueijos()
                    .ToList();
                return Ok(All);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }

        [HttpGet("{key}")]
        public IActionResult PegaPorId(Guid key)
        {
            try
            {
                List<Queijo> FiltroDesc = _QueijoaService.BuscarQueijoPorFiltro(key);
                return Ok(FiltroDesc);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }
        [HttpPost]
        public IActionResult CadrastrarQueijo(Queijo queijo)
        {
            try
            {
                var Cadrastro = _QueijoaService.Incluirqueijo(queijo);
                return Ok(queijo);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }

        [HttpDelete("{key}")]
        public async Task<IActionResult> Remover(Guid key)
        {
            try
            {
                await _QueijoaService.RemoverQueijo(key);
                return Ok();
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }
    }
}