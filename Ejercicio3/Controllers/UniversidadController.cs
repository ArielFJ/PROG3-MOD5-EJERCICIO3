using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3.Controllers
{
    public class UniversidadController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            return View(UniversidadManager.Instance.Universidades);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Universidad universidad)
        {
            if (ModelState.IsValid)
            {
                UniversidadManager.Instance.AgregarUnivesidad(universidad);
                return RedirectToAction("List");
            }
            return View(universidad);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var universidad = UniversidadManager.Instance.ObtenerUniversidad((int)id);

            if (universidad == null) return NotFound();

            return View(universidad);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            UniversidadManager.Instance.EliminarUniversidad(id);
            return RedirectToAction("List");
        }

        public IActionResult Actualizar(int? id)
        {
            if (id == null) return NotFound();

            var universidad = UniversidadManager.Instance.ObtenerUniversidad((int)id);

            if (universidad == null) return NotFound();

            return View(universidad);
        }

        [HttpPost]
        public IActionResult Actualizar(Universidad nuevo, int id) 
        {

            UniversidadManager.Instance.ActualizarUnivesidad(id, nuevo);
            return RedirectToAction("List");
        }

        public IActionResult Docentes(int? id)
        {
            if (id == null) return NotFound();

            var universidad = UniversidadManager.Instance.ObtenerUniversidad((int)id);

            if (universidad == null) return NotFound();

            return View(universidad);
        }

        public IActionResult AgregarDocente(int? id)
        {
            if (id == null) return NotFound();

            var universidad = UniversidadManager.Instance.ObtenerUniversidad((int)id);

            if (universidad == null) return NotFound();

            ViewBag.hasError = false;

            return View(universidad);
        }

        [HttpPost]
        public IActionResult AgregarDocente(int idUniversidad, int idDocente)
        {
            var universidad = UniversidadManager.Instance.ObtenerUniversidad(idUniversidad);
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);
            if (docente != null)
            {
                if (!universidad.Docentes.Contains(docente))
                {
                    ViewBag.hasError = false;
                    universidad.Docentes.Add(docente);
                    docente.Universidades.Add(universidad);
                    return RedirectToAction("Docentes", new { id = idUniversidad });
                }
                else
                {
                    ViewBag.hasError = true;
                    ViewBag.error = $"{docente.Nombre} ya trabaja en {universidad.Nombre}";
                }
            }
            return View(universidad);
        }

        [HttpPost]
        public IActionResult EliminarDocente(int idMaestria, int idDocente)
        {
            var maestria = UniversidadManager.Instance.ObtenerMaestria(idMaestria);
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);

            maestria.Docentes.Remove(docente);
            docente.Maestrias.Remove(maestria);

            return RedirectToAction("Docentes", new { id = idMaestria });
        }
    }
}
