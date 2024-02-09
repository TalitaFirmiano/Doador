using Doador.Api.ViewModel;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _serviceDoador;

        public DoadorController(IDoadorService ServiceDoador)
        {
            _serviceDoador = ServiceDoador;
        }

        [HttpGet("GetById/{doadorId}")]
        public async Task<IActionResult> GetById(int doadorId)
        {
            return Ok(await _serviceDoador.GetById(doadorId));
        }
        [HttpGet("GetAll")]
        public async Task<IEnumerable<DoadorViewModel>> GetAll()
        {
            return (IEnumerable<DoadorViewModel>)Ok(await _serviceDoador.GetAll());
        }        [HttpPut("Update/{doadorId}/{NomeCompleto}")]
        public void Update(int doadorId, string NomeCompleto)
        {
            _serviceDoador.Update(doadorId, NomeCompleto);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] DoadorCommand ServiceDoador)
        {
            var resultado = _serviceDoador.create(ServiceDoador);
            var result = new
            {
                Success = true,
                Data = "Cadastro do Doador realizado com sucesso"
            };

            return Ok(result);
        }
    }
}