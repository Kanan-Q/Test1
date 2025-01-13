using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WepAppTest.Models;

namespace WepAppTest.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> Services()
        {
            return View();
        }
        public async Task<IActionResult> Team()
        {
            return View();
        }
        public async Task<IActionResult> Testimonial()
        {
            return View();
        }
        public async Task<IActionResult> Contact()
        {
            return View();
        }
        public async Task<IActionResult> Appointment()
        {
            return View();
        }
        public async Task<IActionResult> Feature()
        {
            return View();
        }



    }
}
