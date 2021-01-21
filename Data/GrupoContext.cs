using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class GrupoContext : DbContext
    {
        public GrupoContext(DbContextOptions<GrupoContext> options)
        : base(options)
        { }
        
        public DbSet<Grupo> Grupo { get; set; } 

    }
}
