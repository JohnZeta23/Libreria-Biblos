﻿using BiblosBack.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Domain.Entities
{
    public class Autor : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        #region relationships
        public ICollection<Libro> Libros { get; set; }
        #endregion
    }
}
