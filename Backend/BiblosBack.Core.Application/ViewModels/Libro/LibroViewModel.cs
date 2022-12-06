using BiblosBack.Core.Application.ViewModels.Autor;
using BiblosBack.Core.Application.ViewModels.Editorial;
using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Libro
{
    public class LibroViewModel : BaseViewModel
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime Publicacion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        #region relationships
        public int EditorialId { get; set; }
        public EditorialViewModel Editorial { get; set; }
        public int AutorId { get; set; }
        public AutorViewModel Autor { get; set; }
        #endregion
    }
}
