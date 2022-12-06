using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Domain.Entities;
using BiblosBack.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Infrastructure.Persistence.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly BiblosBackContext _dbContext;

        public ClienteRepository(BiblosBackContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
