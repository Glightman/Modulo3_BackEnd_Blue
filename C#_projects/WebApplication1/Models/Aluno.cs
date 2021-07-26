using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_nasc { get; set; }
        public int idade { get => Convert.ToInt32((DateTime.Now - data_nasc).TotalDays/365); }

        public Aluno(int id, string nome, DateTime data_nasc)
        {
            this.id = id;
            this.nome = nome;
            this.data_nasc = data_nasc;
        }
    }
}
