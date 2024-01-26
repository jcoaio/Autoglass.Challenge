using Autoglass.Challenge.Domain.Entities;
using Autoglass.Challenge.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoglass.Challenge.Infra.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        protected readonly AutoglassDbContext context;

        public FornecedorRepository(AutoglassDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Fornecedor>> GetAllAsync()
        {
            return await context.Fornecedor.ToListAsync();
        }
    }
}
