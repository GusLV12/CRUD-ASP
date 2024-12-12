using Microsoft.AspNetCore.Mvc;
using CRUDASP.Datos;
using CRUDASP.Models;

namespace CRUDASP.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            var oList = _ContactoDatos.Listar();
            return View(oList);
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {

            if (!ModelState.IsValid) return View();

            var res = _ContactoDatos.Guardar(oContacto);

            if (res)
            {
                return RedirectToAction("Listar");
            }

            return View();
        }
    }
}