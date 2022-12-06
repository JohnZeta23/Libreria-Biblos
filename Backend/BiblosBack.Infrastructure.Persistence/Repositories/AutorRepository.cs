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
    public class AutorRepository : GenericRepository<Autor>, IAutorRepository
    {
        private readonly BiblosBackContext _dbContext;

        public AutorRepository(BiblosBackContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
