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

        public IActionResult Editar(int idContacto)
        {
            var oContacto = _ContactoDatos.Obtener(idContacto);
            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {

            if (!ModelState.IsValid) return View();

            var res = _ContactoDatos.Editar(oContacto);

            if (res)
            {
                return RedirectToAction("Listar");
            }
            return View(oContacto);
        }

        public IActionResult Eliminar(int idContacto)
        {
            var oContacto = _ContactoDatos.Obtener(idContacto);
            return View(oContacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {

            var res = _ContactoDatos.Eliminar(oContacto.idContacto);

            if (res)
            {
                return RedirectToAction("Listar");
            }
            return View(oContacto);
        }
    }
}