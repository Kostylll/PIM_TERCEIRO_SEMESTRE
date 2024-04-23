using Microsoft.AspNetCore.Mvc;
using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;

namespace PimAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradoresServices _colabService;


        public ColaboradorController(IColaboradoresServices colabService)
        {
            _colabService = colabService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var result = await _colabService.ExibirColaboradores();
            return Ok(result);
        }


        [HttpPost]

        public async Task<IActionResult> AddColab(ColaboradoresResponse response)
        {
            var result = await _colabService.AdicionarColaborador(response);
            return Ok(result);
        }


    }
}
