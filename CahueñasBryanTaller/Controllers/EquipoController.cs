using CahueñasBryanTaller.Models;
using CahueñasBryanTaller.Respositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CahueñasBryanTaller.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {
            EquipoRespository respository = new EquipoRespository();
            var equipos = respository.DevuelveListadoEquipo();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
           
            return View(equipos);
        }
    }
}
