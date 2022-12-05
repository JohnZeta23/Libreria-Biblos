using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application
{
    public static class ApplicationRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
        }
    }
}
