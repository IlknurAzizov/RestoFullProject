using Microsoft.AspNetCore.Mvc;
using Resto.DAL;
using Resto.View_Models;
using System.Linq;

namespace Resto.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.specialtiesMenu = _context.SpecialtiesMenu.ToList();
            return View(homeVM);
        }
    }
}
