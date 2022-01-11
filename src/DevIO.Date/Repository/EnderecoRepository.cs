using DevIO.Business.Interfaces;
using DevIO.Business.Model;
using DevIO.Date.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Date.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context) { }


        public async Task<Endereco> ObeterEndercoPorFornecedor(Guid forncedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == forncedorId);
        }
    }
}
