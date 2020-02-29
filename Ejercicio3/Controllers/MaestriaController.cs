using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3.Controllers
{
    public class MaestriaController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            return View(UniversidadManager.Instance.Maestrias);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Maestria maestria)
        {
            if (ModelState.IsValid)
            {
                UniversidadManager.Instance.AgregarMaestria(maestria);
                return RedirectToAction("List");
            }
            return View(maestria);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null) return NotFound();

            var maestria = UniversidadManager.Instance.ObtenerMaestria((int)id);

            if (maestria == null) return NotFound();

            return View(maestria);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            UniversidadManager.Instance.EliminarMaestria(id);
            return RedirectToAction("List");
        }

        public IActionResult Actualizar(int? id)
        {
            if (id == null) return NotFound();

            var maestria = UniversidadManager.Instance.ObtenerMaestria((int)id);

            if (maestria == null) return NotFound();

            return View(maestria);
        }

        [HttpPost]
        public IActionResult Actualizar(Maestria nuevo, int id)
        {

            UniversidadManager.Instance.ActualizarMaestria(id, nuevo);
            return RedirectToAction("List");
        }

        public IActionResult Docentes(int? id)  
        {
            if (id == null) return NotFound();

            var maestria = UniversidadManager.Instance.ObtenerMaestria((int)id);

            if (maestria == null) return NotFound();

            return View(maestria);
        }

        public IActionResult AgregarDocente(int? id)
        {
            if (id == null) return NotFound();

            var maestria = UniversidadManager.Instance.ObtenerMaestria((int)id);

            if (maestria == null) return NotFound();

            ViewBag.hasError = false;

            return View(maestria);
        }

        [HttpPost]
        public IActionResult AgregarDocente(int idMaestria, int idDocente)
        {
            var maestria = UniversidadManager.Instance.ObtenerMaestria(idMaestria);
            var docente = UniversidadManager.Instance.ObtenerDocente(idDocente);
            if (docente != null)
            {
                if (!maestria.Docentes.Contains(docente))
                {
                    ViewBag.hasError = false;
                    maestria.Docentes.Add(docente);
                    docente.Maestrias.Add(maestria);
                    return RedirectToAction("Docentes", new { id = idMaestria });
                }
                else
                {
                    ViewBag.hasError = true;
                    ViewBag.error = $"{docente.Nombre} ya imparte la maestría de {maestria.Nombre}";
                }
            }
            return View(maestria);
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
