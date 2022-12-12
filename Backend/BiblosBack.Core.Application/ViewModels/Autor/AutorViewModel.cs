using BiblosBack.Core.Application.ViewModels.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Autor
{
    public class AutorViewModel : BaseViewModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ICollection<LibroViewModel> Libros { get; set; }
    }
}
