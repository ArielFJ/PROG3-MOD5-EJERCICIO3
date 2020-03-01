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

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            return View(docente);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            UniversidadManager.Instance.EliminarDocente(id);
            return RedirectToAction("List");
        }

        public IActionResult Actualizar(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            return View(docente);
        }

        [HttpPost]
        public IActionResult Actualizar(Docente nuevo, int id)
        {

            UniversidadManager.Instance.ActualizarDocente(id, nuevo);
            return RedirectToAction("List");
        }

        public IActionResult Maestrias(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            return View(docente);
        }

        public IActionResult AgregarMaestria(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            ViewBag.hasError = false;

            return View(docente);
        }

        [HttpPost]
        public IActionResult AgregarMaestria(int idMaestria, int idDocente)
        {
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);
            var maestria = UniversidadManager.Instance.ObtenerMaestria(idMaestria);
            if (docente != null)
            {
                if (!docente.Maestrias.Contains(maestria))
                {
                    ViewBag.hasError = false;
                    maestria.Docentes.Add(docente);
                    docente.Maestrias.Add(maestria);
                    return RedirectToAction("Maestrias", new { id = idDocente });
                }
                else
                {
                    ViewBag.hasError = true;
                    ViewBag.error = $"La maestría de {maestria.Nombre} ya es impartida por {docente.Nombre}";
                }
            }
            return View(maestria);
        }


        public IActionResult Universidades(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            return View(docente);
        }

        public IActionResult AgregarUniversidad(int? id)
        {
            if (id == null) return NotFound();

            var docente = UniversidadManager.Instance.ObtenerDocente((int)id);

            if (docente == null) return NotFound();

            ViewBag.hasError = false;

            return View(docente); 
        }

        [HttpPost]
        public IActionResult AgregarUniversidad(int idUniversidad, int idDocente)
        {
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);
            var universidad = UniversidadManager.Instance.ObtenerUniversidad(idUniversidad);
            if (docente != null)
            {
                if (!docente.Universidades.Contains(universidad))
                {
                    ViewBag.hasError = false;
                    universidad.Docentes.Add(docente);
                    docente.Universidades.Add(universidad);
                    return RedirectToAction("Universidades", new { id = idDocente });
                }
                else
                {
                    ViewBag.hasError = true;
                    ViewBag.error = $"{docente.Nombre} ya trabaja en {universidad.Nombre}";
                }
            }
            return View(docente);
        }

        [HttpPost]
        public IActionResult EliminarUniversidad(int idDocente, int idUniversidad)
        {
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);
            var universidad = UniversidadManager.Instance.ObtenerUniversidad(idUniversidad);

            docente.Universidades.Remove(universidad);
            universidad.Docentes.Remove(docente);

            return RedirectToAction("Universidades", new { id = idDocente });
        }
    }
}
