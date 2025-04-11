using CahueñasBryanTaller.Models;
using CahueñasBryanTaller.Respositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace CahueñasBryanTaller.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRespository _respository;
       
            public EquipoController()
            {
                _respository = new EquipoRespository();
            }

       

        public ActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {
            
            var equipos = _respository.DevuelveListadoEquipo();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
           
            return View(equipos);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            
            var equipo = _respository.DevuelveEquipoPorID(Id);
            return View(equipo);
        }
        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            try
            {
                
                _respository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }

        }

    }

}
