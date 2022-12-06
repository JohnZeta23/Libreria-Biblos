using AutoMapper;
using BiblosBack.Core.Application.ViewModels.Autor;
using BiblosBack.Core.Application.ViewModels.Cliente;
using BiblosBack.Core.Application.ViewModels.Editorial;
using BiblosBack.Core.Application.ViewModels.Libro;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Autor Mappings
            CreateMap<Autor, AutorViewModel>()
                .ReverseMap();

            CreateMap<Autor, SaveAutorViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Libros, opt => opt.Ignore())
                .ForMember(dest => dest.FechaCreacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.FechaModificacion, opt => opt.Ignore())
                .ForMember(dest => dest.ModificadoPor, opt => opt.Ignore())
                ;
            #endregion

            #region Cliente Mappings
            CreateMap<Cliente, ClienteViewModel>()
                .ReverseMap();

            CreateMap<Cliente, SaveClienteViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.FechaCreacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.FechaModificacion, opt => opt.Ignore())
                .ForMember(dest => dest.ModificadoPor, opt => opt.Ignore())
                ;
            #endregion

            #region Editorial Mappings
            CreateMap<Editorial, EditorialViewModel>()
                .ReverseMap();

            CreateMap<Editorial, SaveEditorialViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Libros, opt => opt.Ignore())
                .ForMember(dest => dest.FechaCreacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.FechaModificacion, opt => opt.Ignore())
                .ForMember(dest => dest.ModificadoPor, opt => opt.Ignore())
                ;
            #endregion

            #region Libro Mappings
            CreateMap<Libro, LibroViewModel>()
                .ReverseMap();

            CreateMap<Libro, SaveLibroViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Editorial, opt => opt.Ignore())
                .ForMember(dest => dest.Autor, opt => opt.Ignore())
                .ForMember(dest => dest.FechaCreacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.FechaModificacion, opt => opt.Ignore())
                .ForMember(dest => dest.ModificadoPor, opt => opt.Ignore())
                ;
            #endregion
        }
    }
}
