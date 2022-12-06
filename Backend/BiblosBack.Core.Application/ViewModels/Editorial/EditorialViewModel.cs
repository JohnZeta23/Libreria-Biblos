using BiblosBack.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Autor
{
    public class EditorialViewModel : BaseViewModel
    {
        public string Nombre { get; set; }

        public ICollection<LibroViewModel> Libros { get; set; }
    }
}
