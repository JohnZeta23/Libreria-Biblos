using BiblosBack.Core.Application.Interfaces;
using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Autor;
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
    public class autorController : GenericController<Autor,AutorViewModel,SaveAutorViewModel>
    {
        private readonly IAutorService _services;
        public autorController(IAutorService service) :base(service) 
        {
            _services = service;
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AutorViewModel>))]
        public async override Task<IActionResult> getAll()
        {
            return await base.getAll();
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SaveAutorViewModel))]
        public async override Task<IActionResult> update(SaveAutorViewModel viewModel,int id)
        {
            return await base.update(viewModel, id);
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AutorViewModel>))]
        public async override Task<IActionResult> getallWithRelation(List<string>properties)
        {
            return await base.getallWithRelation(properties);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AutorViewModel))]
        public async override Task<IActionResult> getByIdSaveVM(int id)
        {
            return await base.getByIdSaveVM(id);
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AutorViewModel))]
        public async override Task<IActionResult> getByIdVM(int id)
        {
            return await base.getByIdVM(id);
        }

    }
}