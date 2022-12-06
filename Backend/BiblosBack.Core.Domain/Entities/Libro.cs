using BiblosBack.Core.Domain.Common;
using System;

namespace BiblosBack.Core.Domain.Entities
{
    public class Libro : BaseEntity
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime Publicacion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        #region relationships
        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        #endregion
    }
}
