using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepAppTest.Context;
using WepAppTest.Models;
using WepAppTest.ViewModels.Doctors;

namespace WepAppTest.Areas.Admin.Controllers
{
    public class DoctorController(AppDbContext _context, IWebHostEnvironment _env) : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctors.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DoctorCreateVM vm)
        {
            if (!vm.Photo.ContentType.StartsWith("image"))
            {
                ModelState.AddModelError("Photo", "image deyil");
                return View();
            }
            if (vm.Photo.Length < 5 * 1024 * 1024)
            {
                ModelState.AddModelError("Photo", "image deyil");
                return View();
            }
            if (!ModelState.IsValid) { ViewBag.Departments = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync(); return View(); }

            var filename = Path.GetRandomFileName() + Path.GetExtension(vm.Photo.FileName);
            using (Stream s = System.IO.File.Create(Path.Combine(_env.WebRootPath, "images", "doctor", filename)))
            {
                await vm.Photo.CopyToAsync(s);
            }

            if (ModelState.IsValid) return BadRequest();
            Doctor d = new Doctor()
            {
                Age = vm.Age,
                Name = vm.Name,
                Surname = vm.Surname,
                Salary = vm.Salary,
                Photo= filename
            };
            await _context.Doctors.AddAsync(d);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {

            if (!id.HasValue) return BadRequest();
            var data = await _context.Doctors.Where(x=>x.Id==id.Value).Select(x=> new DoctorUpdateVM {

                Age=x.Age, Name=x.Name, Salary=x.Salary,SurName=x.Surname,CoverPhoto=x.Photo

            }).FirstOrDefaultAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id,DoctorUpdateVM vm)
        {
            if (!id.HasValue) return BadRequest();
            if (vm.Photo != null)
            {
                if (!vm.Photo.ContentType.StartsWith("image"))
                {
                    ModelState.AddModelError("Photo", "Image deyil");
                }
                if (vm.Photo.Length < 5 * 1024 * 1024)
                {
                    ModelState.AddModelError("Photo", "maks 5mb");
                }
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = await _context.Departments.Where(x => !x.IsDeleted).ToListAsync();
                return View(vm);
            }
            var data = await _context.Doctors.Where(x => x.Id == id.Value).FirstOrDefaultAsync();
            string oldName = Path.Combine(_env.WebRootPath, "imgs", "products", data.Photo);

            using (Stream s = System.IO.File.Create(Path.Combine(oldName))) 
            {
                await vm.Photo!.CopyToAsync(s);
            }
            data.Surname = vm.SurName;
            data.Name = vm.Name;
            data.Age = vm.Age;
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Doctors.FindAsync(id.Value);
            if (data is null) return NotFound();
            _context.Doctors.Remove(data);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Hide(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Doctors.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Show(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var data = await _context.Doctors.FindAsync(id.Value);
            if (data is null) return NotFound();
            data.IsDeleted = false;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



    }
}
