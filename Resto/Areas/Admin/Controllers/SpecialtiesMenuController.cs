using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resto.DAL;
using Resto.Models;

namespace Resto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialtiesMenuController : Controller
    {
        private readonly AppDbContext _context;

        public SpecialtiesMenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<SpecialtiesMenu> blog = _context.SpecialtiesMenu.ToList();
            return View(blog);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            SpecialtiesMenu dbSpecMenu = await _context.SpecialtiesMenu.FindAsync(id);
            if (dbSpecMenu == null) return NotFound();

            return View(dbSpecMenu);

        }
        

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            SpecialtiesMenu dbSpecMenu = await _context.SpecialtiesMenu.FindAsync(id);
            if (dbSpecMenu == null) return NotFound();
            _context.SpecialtiesMenu.Remove(dbSpecMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
