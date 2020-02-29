using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3.Controllers
{
    public class DocenteController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            return View(UniversidadManager.Instance.Docentes);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Docente docente)
        {
            if (ModelState.IsValid)
            {
                UniversidadManager.Instance.AgregarDocente(docente);
                return RedirectToAction("List");
            }
            return View(docente);
        }
    }
}
