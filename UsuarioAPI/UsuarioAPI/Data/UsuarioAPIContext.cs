using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Model;

namespace UsuarioAPI.Data
{
    public class UsuarioAPIContext : DbContext
    {
        public UsuarioAPIContext (DbContextOptions<UsuarioAPIContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioAPI.Model.Usuario> Usuario { get; set; }
    }
}
