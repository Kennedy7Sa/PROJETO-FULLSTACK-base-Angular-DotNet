using System.Collections.Generic;
using ApiFuncionarios.DataContext;
using ApiFuncionarios.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncionarios.Services.Funcionario
{
    public class FuncionarioService : IFuncionarioServiceInterface
    {
        private readonly AppDbContexto _context;

        public FuncionarioService(AppDbContexto context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<FuncionarioModel>>> AtualizarFuncionario(FuncionarioModel funcionarioEditado)
        {
            ResponseModel<List<FuncionarioModel>> resposta = new ResponseModel<List<FuncionarioModel>>();
            try
            {
                var funcionario = await _context.Funcionarios.AsNoTracking().FirstOrDefaultAsync(f => f.Id == funcionarioEditado.Id);  
                
                if(funcionarioEditado == null)
                {
                    resposta.Mensagem = "Preencha os dados a serem atualizados";
                   
                }
                _context.Funcionarios.Update(funcionarioEditado);
                 await _context.SaveChangesAsync();

                resposta.Mensagem = "Funcionario Atualizado com sucesso";
                resposta.Dados = _context.Funcionarios.ToList();
                return resposta;




            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Sucesso = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<FuncionarioModel>> BuscarFuncionarioPorId(int id)
        {
            ResponseModel<FuncionarioModel> resposta = new ResponseModel<FuncionarioModel>();

            try
            {
                var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(f => f.Id == id);
                if(funcionario == null)
                {
                    resposta.Mensagem = "Funcionario não encontrado";
                    
                }
                resposta.Dados = funcionario;
                resposta.Mensagem = "Funcionario encontrado com sucesso !";



            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Sucesso = false;
            }
            return resposta;
        }

        public async Task<ResponseModel<List<FuncionarioModel>>> CriarFuncionario(FuncionarioModel novoFuncionario)
        {
            ResponseModel < List < FuncionarioModel >> resposta = new ResponseModel<List<FuncionarioModel>> ();

            try
            {
                if(novoFuncionario == null)
                {
                    resposta.Mensagem = "Favor Informar os dados ";
                    return resposta;
                }
                _context.Add(novoFuncionario);
                await _context.SaveChangesAsync();

                resposta.Dados = _context.Funcionarios.ToList();
                

            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Sucesso = false;
                
            }
            return resposta;



        }

        public async Task<ResponseModel<List<FuncionarioModel>>> DeletarFuncionario(int id)
        {
            ResponseModel<List<FuncionarioModel>> resposta = new ResponseModel<List<FuncionarioModel>>();
            try
            {
                var funcionario = _context.Funcionarios.Find(id);
                if (funcionario == null)
                {
                    resposta.Mensagem = "Nenhum funcionario encontrado com esse ID";
                    return resposta;
                }
                resposta.Mensagem = "Funcionario removido com sucesso";
                _context.Funcionarios.Remove(funcionario);
                await _context.SaveChangesAsync();

                resposta.Dados = _context.Funcionarios.ToList();
                return resposta;



            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Sucesso = false;
                return resposta;
            }
            



        }

        public async Task<ResponseModel<List<FuncionarioModel>>> ListarFuncionarios()
        {
            ResponseModel<List<FuncionarioModel>> resposta = new ResponseModel<List<FuncionarioModel>>();
            try
            {
                resposta.Dados =  _context.Funcionarios.ToList();
                if(resposta.Dados.Count() == 0)
                {
                    resposta.Mensagem = "Nenhum funcionario encontrado";                   
                }              
               
             }
            catch (Exception ex)
            {
               
                resposta.Mensagem = ex.Message;
                resposta.Sucesso = false;
                
            }
            return resposta;
        }
    }
}
