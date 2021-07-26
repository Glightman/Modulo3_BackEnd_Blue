using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        public List<Aluno> alunos = new();
        public void OnGet()
        {
            this.alunos.Add(new Aluno(1, "Gabriel", new DateTime(1997,08,07)));
            this.alunos.Add(new Aluno(2, "Karol", new DateTime(1997,04,08)));
            this.alunos.Add(new Aluno(3, "Amana", new DateTime(2000,11,21)));
            this.alunos.Add(new Aluno(4, "Jemima", new DateTime(1992,11,04)));
        }
    }
}
