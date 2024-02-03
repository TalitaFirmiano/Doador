using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;

        public VeiculoController(IDoadorService doadorService)
        {
            _doadorService = DoadorService;
        }
        [HttpPost]
        [Route("Cadastrar Doador")]
        public async Task<IActionResult> PostAsync([FromBody]  command)
        {
            return Ok(await _doadorService.PostAsync(command));
        }
    }
}
