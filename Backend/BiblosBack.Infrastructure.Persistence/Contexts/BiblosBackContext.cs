using BiblosBack.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Infrastructure.Persistence.Contexts
{
    public class BiblosBackContext:DbContext
    {
        public BiblosBackContext(DbContextOptions<BiblosBackContext> options):base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            #region Autor
            model.Entity<Autor>().ToTable("Autores");
            model.Entity<Autor>().HasKey(x => x.Id);
            model.Entity<Autor>().Property(x => x.Nombre);
            model.Entity<Autor>().Property(x => x.Apellido);
            model.Entity<Autor>().Property(x => x.FechaCreacion);
            model.Entity<Autor>().Property(x => x.CreadoPor);
            #endregion

            #region Cliente
            model.Entity<Cliente>().ToTable("Clientes");
            model.Entity<Cliente>().HasKey(x => x.Id);
            model.Entity<Cliente>().Property(x => x.Nombre);
            model.Entity<Cliente>().Property(x => x.Apellido);
            model.Entity<Cliente>().Property(x => x.Email);
            model.Entity<Cliente>().Property(x => x.Contraseña);
            model.Entity<Cliente>().Property(x => x.FechaCreacion);
            model.Entity<Cliente>().Property(x => x.CreadoPor);
            #endregion

            #region Editorial
            model.Entity<Editorial>().ToTable("Editoriales");
            model.Entity<Editorial>().HasKey(x => x.Id);
            model.Entity<Editorial>().Property(x => x.Nombre);
            model.Entity<Editorial>().Property(x => x.FechaCreacion);
            model.Entity<Editorial>().Property(x => x.CreadoPor);
            #endregion

            #region Libro
            model.Entity<Libro>().ToTable("Libros");
            model.Entity<Libro>().HasKey(x => x.Id);
            model.Entity<Libro>().Property(x => x.Nombre);
            model.Entity<Libro>().Property(x => x.Codigo);
            model.Entity<Libro>().Property(x => x.Publicacion);
            model.Entity<Libro>().Property(x => x.Precio);
            model.Entity<Libro>().Property(x => x.Stock);
            model.Entity<Libro>().Property(x => x.EditorialId);
            model.Entity<Libro>().Property(x => x.AutorId);
            model.Entity<Libro>().Property(x => x.FechaCreacion);
            model.Entity<Libro>().Property(x => x.CreadoPor);
            #endregion

            #region relationships
            model.Entity<Editorial>()
                .HasMany(e => e.Libros)
                .WithOne(l => l.Editorial)
                .HasForeignKey(l => l.EditorialId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<Autor>()
                .HasMany(a => a.Libros)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.AutorId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
