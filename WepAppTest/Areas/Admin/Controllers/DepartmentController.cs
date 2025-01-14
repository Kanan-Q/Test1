using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepAppTest.Context;
using WepAppTest.Models;
using WepAppTest.ViewModels.Departments;

namespace WepAppTest.Areas.Admin.Controllers
{
    public class DepartmentController(AppDbContext _context) : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentCreateVM cm)
        {
            if (!ModelState.IsValid) return BadRequest();
            Department d = new Department()
            {
                DepartmentName = cm.DepartmentName
            };
            await _context.Departments.AddAsync(d);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.Where(x => x.Id == id.Value).Select(x => new DepartmentUpdateVM
            {
               DepartmentName= x.DepartmentName
            }).FirstOrDefaultAsync();
            if (data is null) return BadRequest();
            return View(data);
        }



        [HttpPost]
        public async Task<IActionResult> Update(int? id,DepartmentUpdateVM vm)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.Where(x => x.Id == id.Value).FirstOrDefaultAsync();
            data.DepartmentName= vm.DepartmentName;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.FindAsync(id.Value);
            if (data is null) return NotFound();
            _context.Departments.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Hide(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Show(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Departments.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.IsDeleted = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
