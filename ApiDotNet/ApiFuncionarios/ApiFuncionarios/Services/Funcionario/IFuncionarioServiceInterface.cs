using ApiFuncionarios.Models;

namespace ApiFuncionarios.Services.Funcionario
{
    public interface IFuncionarioServiceInterface
    {
        Task<ResponseModel<List<FuncionarioModel>>> CriarFuncionario(FuncionarioModel novoFuncionario);

        Task<ResponseModel<List<FuncionarioModel>>> ListarFuncionarios();
        Task<ResponseModel<FuncionarioModel>> BuscarFuncionarioPorId(int id);

        Task<ResponseModel<List<FuncionarioModel>>> DeletarFuncionario(int id);

        Task<ResponseModel<List<FuncionarioModel>>> AtualizarFuncionario(FuncionarioModel funcionarioEditado);
    }
}
