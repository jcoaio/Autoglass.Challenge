using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Autoglass.Challenge.Application.Interfaces;
using Autoglass.Challenge.DTOs;

namespace Autoglass.Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoApplicationService _produtoApplicationService;
        public ProdutosController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }


        [HttpGet()]
        public async Task<IActionResult> GetAllAsync([FromQuery] ProdutoPaginacaoRequest paginacaoRequest)
        {
            var produtos = await _produtoApplicationService.GetAllAsync(paginacaoRequest);

            if (produtos == null)
                return NotFound("Nenhum produto.");

            return Ok(
                produtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var produto = await _produtoApplicationService.GetByIdAsync(id);

            if (produto == null)
                return NotFound("Produto não encontrado.");

            return Ok(
                produto);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProdutoAsync([FromBody] ProdutoUpdateRequest produto)
        {

            if (!await _produtoApplicationService.ExistAsync(produto.Id))
                return NotFound("Produto não encontrado.");

            if (!ModelState.IsValid)
                return BadRequest();

            await _produtoApplicationService.UpdateProdutoAsync(produto);

            return Ok(produto);

        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProdutoAsync(int id)
        {

            if (!await _produtoApplicationService.ExistAsync(id))
                return NotFound("Produto não encontrado.");

            await _produtoApplicationService.DeleteProdutoAsync(id);

            return Ok("Produto deletado com sucesso.");

        }

        [HttpPost]
        public async Task<IActionResult> InsertProdutoAsync([FromBody] ProdutoInsertRequest produto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            await _produtoApplicationService.InsertProdutoAsync(produto);

            return StatusCode(201, produto);

        }
    }
}
