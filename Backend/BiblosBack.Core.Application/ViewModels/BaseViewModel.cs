using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string ModificadoPor { get; set; }
    }
}
