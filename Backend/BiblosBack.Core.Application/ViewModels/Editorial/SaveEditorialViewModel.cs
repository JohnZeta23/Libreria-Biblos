using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels.Editorial
{
    public class SaveEditorialViewModel
    {
        public int Id{ get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
    }
}
