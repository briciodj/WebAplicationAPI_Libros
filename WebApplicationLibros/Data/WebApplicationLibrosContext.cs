using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationLibros.Modelo;

namespace WebApplicationLibros.Data
{
    public class WebApplicationLibrosContext : DbContext
    {
        public WebApplicationLibrosContext (DbContextOptions<WebApplicationLibrosContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationLibros.Modelo.Libros>? Libros { get; set; }
    }
}
