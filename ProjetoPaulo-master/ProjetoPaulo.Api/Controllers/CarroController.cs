using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPaulo.Data.Entity;
using ProjetoPaulo.Service.Interface;

namespace ProjetoPaulo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _CarroService;

        public CarroController(ICarroService CarroService)
        {
            _CarroService = CarroService;
        }

        [HttpGet]
        public IActionResult All()
        {
            try
            {
                var All = _CarroService.TodosOsCarros();
                return Ok(All);
            }
            catch(Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }

        [HttpGet]
        public IActionResult BuscarCarroId(Guid key)
        {
            try
            {
                var filtro = _CarroService.BuscarCarroId(key);
                return Ok(filtro);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
            
        }

        [HttpPost]
        public IActionResult IncluirCarro(Carro carro)
        {
            try
            {
                //var Incluir = _CarroService.IncluirCarro(carro);
                return Ok();

            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Remover(Guid key)
        {
            try
            {
                var remove = _CarroService.RemoverCarro(key);
                return Ok(remove);
            }
            catch (Exception Ex)
            {
                return NotFound(Ex.Message);
            }
        }
    }
}