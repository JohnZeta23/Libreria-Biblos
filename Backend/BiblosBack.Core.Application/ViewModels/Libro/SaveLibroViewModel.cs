using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Libro
{
    public class SaveLibroViewModel
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime Publicacion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int EditorialId { get; set; }
        public int AutorId { get; set; }
    }
}
