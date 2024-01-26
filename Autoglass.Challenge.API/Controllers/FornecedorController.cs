using Autoglass.Challenge.Application.Interfaces;
using Autoglass.Challenge.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Autoglass.Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplicationService _fornecedorApplicationService;
        public FornecedorController(IFornecedorApplicationService fornecedorApplicationService)
        {
            _fornecedorApplicationService = fornecedorApplicationService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetAllAsync()
        {
            var fornecedores = await _fornecedorApplicationService.GetAllAsync();

            if (fornecedores == null)
                return NotFound("Nenhum fornecedor cadastrado.");

            return Ok(
                fornecedores);
        }
    }
}
