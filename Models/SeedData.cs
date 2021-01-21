using Crud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider) 
        
        {
            using (var context = new GrupoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GrupoContext>>()))
            {

                if (context.Grupo.Any())
                {
                    return;   // DB has been seeded
                }

                context.Grupo.AddRange(
                    new Grupo
                    {
                        Codigo = 01,
                        Descricao = "GRUPO DE VACINAS",
                        Status = true
                    },
                    new Grupo
                    {
                        Codigo = 40,
                        Descricao = "GRUPO DE MEIAS",
                        Status = false
                    }
                        );

                context.SaveChanges();


            }
        }
    }
}
