using AutoMapper;
using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Editorial;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Services
{
    public class EditorialService : GenericService<Editorial, EditorialViewModel, SaveEditorialViewModel>, IEditorialService
    {
        private readonly IEditorialRepository _editorialRepository;
        private readonly IMapper _mapper;

        public EditorialService(IEditorialRepository EditorialRepository, IMapper mapper) : base(EditorialRepository, mapper)
        {
            _editorialRepository = EditorialRepository;
            _mapper = mapper;
        }
    }
}
