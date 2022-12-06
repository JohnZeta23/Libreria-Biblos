using AutoMapper;
using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Autor;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Services
{
    public class AutorService : GenericService<Autor, AutorViewModel, SaveAutorViewModel>, IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;

        public AutorService(IAutorRepository autorRepository, IMapper mapper) : base(autorRepository, mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }
    }
}
