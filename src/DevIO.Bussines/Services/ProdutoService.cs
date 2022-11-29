using DevIO.Bussines.Interfaces;
using DevIO.Bussines.Models;
using DevIO.Bussines.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Bussines.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}
