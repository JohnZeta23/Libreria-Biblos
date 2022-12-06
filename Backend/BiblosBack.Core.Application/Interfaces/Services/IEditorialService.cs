using BiblosBack.Core.Application.ViewModels.Editorial;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Interfaces.Services
{
    public interface IEditorialService : IGenericService<Editorial, EditorialViewModel, SaveEditorialViewModel>
    {
    }
}
