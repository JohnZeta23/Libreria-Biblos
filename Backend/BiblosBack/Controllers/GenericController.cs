using BiblosBack.Core.Application.Interfaces.Services;
using BiblosBack.Core.Application.ViewModels.Autor;
using BiblosBack.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mime;
using System.Threading.Tasks;

namespace BiblosBack.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class GenericController<Entity, VM, SaveVM> : ControllerBase
        where Entity : class
        where SaveVM : class
        where VM : class
    {
        private readonly IGenericService<Entity, VM, SaveVM> _services;

        public GenericController(IGenericService<Entity, VM, SaveVM> services)
        {
            _services = services;
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> Add(SaveVM saveVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Todos los campos son obligatorios.");
                }

                var vm = await _services.Add(saveVM);

                if (vm == null)
                {
                    return BadRequest("Ha ocurrido un problema.");
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }
        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var entity = await _services.GetByIdViewModel(id);

                if (entity == null)
                {
                    return NotFound();
                }

                if (!await _services.Delete(id))
                {
                    return BadRequest();
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("getAll")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> getAll()
        {
            try
            {
                var list = await _services.GetAllViewModel();

                if (list.Count == 0)
                {
                    return NotFound();
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("getAllWitRelation/{properties}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> getallWithRelation(List<string> properties)
        {
            try
            {
                var list = await _services.GetAllViewModelRelation(properties);

                if (list.Count == 0)
                {
                    return NotFound();
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("update/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> update(SaveVM saveVM, int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                if (saveVM == null)
                {
                    return BadRequest();
                }

                var entity = await _services.GetByIdViewModel(id);

                if (entity == null)
                {
                    return NotFound();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Todos los campos son obligatorios.");
                }

                bool res = await _services.Update(saveVM, id);

                if (!res)
                {
                    return BadRequest();
                }

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("getByVMId/{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> getByIdVM(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var entity = await _services.GetByIdViewModel(id);

                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("getByIdSaveVM/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<IActionResult> getByIdSaveVM(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var entity = await _services.GetByIdSaveViewModel(id);

                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
