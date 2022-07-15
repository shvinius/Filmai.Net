using Kino_festivalis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kino_festivalis.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            FilmContext context = HttpContext.RequestServices.GetService(typeof(Kino_festivalis.Models.FilmContext)) as FilmContext;
            return View(context.GautiVisusFilmus());
        }
    }
}
