using DevIO.Business.Interfaces;
using DevIO.Business.Interfaces.InterfacesServices;
using DevIO.Business.Model;
using DevIO.Business.Model.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class ProdutoServise : BaseService, IProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoServise(IProdutoRepository produtoRepository, INotificador notificador)
            : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }
        
        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }

    }
}
