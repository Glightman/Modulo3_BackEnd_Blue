using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
    }
}
