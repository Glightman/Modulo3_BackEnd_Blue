using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            List<Paciente> listaDePacientes = new List<Paciente>();
            listaDePacientes.Add(new Paciente {  id = 1, nome = "Gabriel Lima"});
            listaDePacientes.Add(new Paciente {  id = 2, nome = "Karolaine Santana"});
            listaDePacientes.Add(new Paciente {  id = 3, nome = "Rafael Almeida"});
            listaDePacientes.Add(new Paciente {  id = 4, nome = "Matheus dos Santos"});

            ViewBag.pacientes = listaDePacientes;
            return View();
        }
    }
}
