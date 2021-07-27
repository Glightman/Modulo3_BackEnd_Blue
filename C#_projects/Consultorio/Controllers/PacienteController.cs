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


        public IActionResult Index(int id) // Pacientes/Index/3
        {
            List<Paciente> pacientes = id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id);
            return View(pacientes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente p)
        {
            List<Paciente> pacientes = getPacientes();
            p.Id = pacientes.Count() + 1;
            pacientes.Add(p);
            ViewBag.lista = pacientes;
            return View("Index");
        }
        public IActionResult Sucesso()
        {
            return View();
        }
        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo" });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo" });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio" });
            return listaPacientes;
        }
    }
}
