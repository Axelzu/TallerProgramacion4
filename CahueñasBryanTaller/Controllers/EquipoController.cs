using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CahueñasBryanTaller.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
}
