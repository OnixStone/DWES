using ExamenFinalDWES.Models;
using Microsoft.AspNetCore.Mvc;
using ExamenFinalDWES.Models;
using ExamenFinalDWES.Repository;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinalDWES.Controllers
{
    public class LoginController : Controller
    {
        private readonly AmazonMontecasteloContext _context;

        public LoginController(AmazonMontecasteloContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Index(Login login)
        {
            var user = _context.Logins.FirstOrDefault(l => l.Nombre == login.Nombre && l.Password == login.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "El nombre de usuario o la contraseña son incorrectos");
                return View(login);
            }
        }

        [HttpPost]
        public IActionResult Logueate(Login login)
        {
            var user = _context.Logins.FirstOrDefault(l => l.Nombre == login.Nombre && l.Password == login.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "El nombre de usuario o la contraseña son incorrectos");
                return View(login);
            }
        }

    }
}
