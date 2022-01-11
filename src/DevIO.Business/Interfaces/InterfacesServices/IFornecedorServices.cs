using DevIO.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces.InterfacesServices
{
    public interface IFornecedorServices : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor fornecedor);

        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
