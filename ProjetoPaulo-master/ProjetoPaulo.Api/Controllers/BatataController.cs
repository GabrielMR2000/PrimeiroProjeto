using Microsoft.AspNetCore.Mvc;
using ProjetoPaulo.Domain.Model;
using ProjetoPaulo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPaulo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatataController : ControllerBase
    {
        private readonly IBatataService _batataService;

        public BatataController(IBatataService batataService)
        {
            _batataService = batataService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarBatatas(string descricao)
        {
            try
            {
                List<Batata> batatas = await _batataService.BuscarBatata(descricao);
                return Ok(batatas);
            }
            catch (Exception ex)
            {
                return CatchAll(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarBatata(Batata batata)
        {
            try
            {
                var bat = await _batataService.IncluirBatata(batata);
                return Ok(bat);//200
            }
            catch (Exception ex)
            {
                return CatchAll(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AlterarBatata(Batata batata)
        {
            try
            {
                var bat = await _batataService.AlterarBatata(batata);
                return Ok(bat);//200
            }
            catch (Exception ex)
            {
                return CatchAll(ex);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoverBatata(Batata batata)
        {
            try
            {
                await _batataService.RemoverBatata(batata);
                return Ok("Batata removida com sucesso!");//200
            }
            catch (Exception ex)
            {
                return CatchAll(ex);
            }
        }

        private IActionResult CatchAll(Exception ex)
        {
            var response = new
            {
                Error = true,
                Msg = ex.Message,
                excecao = ex
            };
            return BadRequest(response);
        }
    }
}
