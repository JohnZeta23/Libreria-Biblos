using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Autor
{
    public class SaveAutorViewModel
    {
        public int Id { get; set; } = 0;
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
    }
}
