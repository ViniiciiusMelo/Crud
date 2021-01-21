using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Grupo
    {

        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Descricao { get; set; }


        public Boolean Status { get; set; }

    }
}


