using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class MonstrosController : Controller
    {
        public IActionResult Index()
        {
            List<Monstros> listaDeMonstros = new List<Monstros>();
            listaDeMonstros.Add(new Monstros { id = 1, nome = "Zombie", ataque = 2});
            listaDeMonstros.Add(new Monstros { id = 2, nome = "Esqueleto", ataque = 4});
            listaDeMonstros.Add(new Monstros { id = 1, nome = "Creeper", ataque = 7});

            ViewBag.monstros = listaDeMonstros;
            return View();
        }
    }
}
