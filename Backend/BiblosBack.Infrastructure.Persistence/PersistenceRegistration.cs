using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Infrastructure.Persistence.Contexts;
using BiblosBack.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Infrastructure.Persistence
{
    public static class PersistenceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BiblosBackContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("BiblosDB"),
                    builder => builder.MigrationsAssembly(typeof(BiblosBackContext).Assembly.FullName)));

            //Here dependency injection
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
