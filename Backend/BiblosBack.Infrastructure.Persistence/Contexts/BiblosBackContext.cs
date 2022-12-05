using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Infrastructure.Persistence.Contexts
{
    public class BiblosBackContext:DbContext
    {
        public BiblosBackContext(DbContextOptions<BiblosBackContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {

        }
    }
}
