using AutoMapper;
using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Libro;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Services
{
    public class LibroService : GenericService<Libro, LibroViewModel, SaveLibroViewModel>, ILibroService
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;

        public LibroService(ILibroRepository LibroRepository, IMapper mapper) : base(LibroRepository, mapper)
        {
            _libroRepository = LibroRepository;
            _mapper = mapper;
        }
    }
}
