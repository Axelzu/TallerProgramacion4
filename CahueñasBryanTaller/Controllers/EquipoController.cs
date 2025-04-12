using CahueñasBryanTaller.Models;
using CahueñasBryanTaller.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CahueñasBryanTaller.Controllers
{
    public class EquipoController : Controller
    {
        private static EquipoRespository _respository = new EquipoRespository();

        public IActionResult List()
        {
            var equipos = _respository.ObtenerTodos();
            return View(equipos);
        }

        // Crear
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _respository.AgregarEquipo(equipo);
                return RedirectToAction("List");
            }
            return View(equipo);
        }

        // Editar
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var equipo = _respository.DevuelveEquipoPorID(id);
            return View(equipo);
        }

        [HttpPost]
        public IActionResult Edit(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _respository.ActualizarEquipo(equipo.Id, equipo);
                return RedirectToAction("List");
            }
            return View(equipo);
        }

        // Eliminar
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _respository.EliminarEquipo(id);
            return RedirectToAction("List");
        }

        // Ver Detalles
        public IActionResult Details(int id)
        {
            var equipo = _respository.DevuelveEquipoPorID(id);
            return View(equipo);
        }
    }
}
