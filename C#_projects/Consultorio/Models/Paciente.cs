using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Paciente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_nasc { get; set; }
    }
}
