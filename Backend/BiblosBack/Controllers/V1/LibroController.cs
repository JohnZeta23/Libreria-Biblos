using BiblosBack.Core.Application.Interfaces;
using BiblosBack.Core.Application.Interfaces.Services;

using BiblosBack.Core.Application.ViewModels.Libro;
using BiblosBack.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BiblosBack.Controllers.V1
{

    [ApiVersion("1.0")]
    public class libroController : GenericController<Libro, LibroViewModel, SaveLibroViewModel>
    {
        private readonly ILibroService _services;
        public libroController(ILibroService service) : base(service)
        {
            _services = service;
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LibroViewModel>))]
        public async override Task<IActionResult> getAll()
        {
            return await base.getAll();
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LibroViewModel))]
        public async override Task<IActionResult> update(SaveLibroViewModel viewModel, int id)
        {
            return await base.update(viewModel, id);
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LibroViewModel>))]
        public async override Task<IActionResult> getallWithRelation(List<string> properties)
        {
            return await base.getallWithRelation(properties);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LibroViewModel))]
        public async override Task<IActionResult> getByIdSaveVM(int id)
        {
            return await base.getByIdSaveVM(id);
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LibroViewModel))]
        public async override Task<IActionResult> getByIdVM(int id)
        {
            return await base.getByIdVM(id);
        }

    }
}