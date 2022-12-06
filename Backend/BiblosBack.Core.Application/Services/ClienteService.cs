using AutoMapper;
using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Cliente;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Services
{
    public class ClienteService : GenericService<Cliente, ClienteViewModel, SaveClienteViewModel>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository ClienteRepository, IMapper mapper) : base(ClienteRepository, mapper)
        {
            _clienteRepository = ClienteRepository;
            _mapper = mapper;
        }
    }
}
