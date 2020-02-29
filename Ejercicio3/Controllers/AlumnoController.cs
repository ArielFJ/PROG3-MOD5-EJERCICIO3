using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            return View(UniversidadManager.Instance.Alumnos);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                UniversidadManager.Instance.AgregarAlumno(alumno);
                return RedirectToAction("List");
            }
            return View(alumno);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var alumno = UniversidadManager.Instance.ObtenerAlumno((int)id);

            if (alumno == null) return NotFound();

            return View(alumno);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            UniversidadManager.Instance.EliminarAlumno(id);
            return RedirectToAction("List");
        }

        public IActionResult Actualizar(int? id)
        {
            if (id == null) return NotFound();

            var alumno = UniversidadManager.Instance.ObtenerAlumno((int)id);

            if (alumno == null) return NotFound();

            return View(alumno);
        }

        [HttpPost]
        public IActionResult Actualizar(Alumno nuevo, int id)
        {

            UniversidadManager.Instance.ActualizarAlumno(id, nuevo);
            return RedirectToAction("List");
        }

        public IActionResult Maestrias(int? id)
        {
            if (id == null) return NotFound();

            var alumno = UniversidadManager.Instance.ObtenerAlumno((int)id);

            if (alumno == null) return NotFound();

            return View(alumno);
        }

        public IActionResult AgregarMaestria(int id)
        {
            return View(UniversidadManager.Instance.ObtenerAlumno(id));
        }

        [HttpPost]
        public IActionResult AgregarMaestria(int id, Maestria maestria)
        {
            return Json(maestria);
        }
    }
}
