using ApiFuncionarios.Models;
using ApiFuncionarios.Services.Funcionario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioServiceInterface _funcionarioServiceInterface;

        public FuncionarioController(IFuncionarioServiceInterface funcionarioServiceInterface)
        {
            _funcionarioServiceInterface = funcionarioServiceInterface;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseModel<List<FuncionarioModel>>>> CriarFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _funcionarioServiceInterface.CriarFuncionario(novoFuncionario));
        }

        [HttpGet]
        public async Task<ActionResult<ResponseModel<List<FuncionarioModel>>>> ListarFuncionarios()
        {
            return Ok(await _funcionarioServiceInterface.ListarFuncionarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseModel<FuncionarioModel>>> BuscarFuncionarioPorId(int id)
        {
            return Ok(await _funcionarioServiceInterface.BuscarFuncionarioPorId(id));
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseModel<List<FuncionarioModel>>>> DeletarFuncionario(int id)
        {
            return Ok(await _funcionarioServiceInterface.DeletarFuncionario(id));
        }

        [HttpPut]
        public async Task<ActionResult<ResponseModel<List<FuncionarioModel>>>> AtualizarFuncionario(FuncionarioModel funcionarioEditado)
        {
            return Ok(await _funcionarioServiceInterface.AtualizarFuncionario(funcionarioEditado));
        }
    }
}
