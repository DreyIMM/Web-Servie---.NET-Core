using DevIO.Bussines.Interfaces;
using DevIO.Bussines.Models;
using DevIO.Bussines.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async  Task Adicionar(Fornecedor fornecedor)
        {

          //Validar o estado da entidade
          if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) && 
              !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

          //Se não existe fornecedor com o mesmo documento
                       
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor))  return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}
