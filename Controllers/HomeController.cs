using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAssignment.Context;
using WebAssignment.Models;

namespace WebAssignment.Controllers
{
    public class HomeController : Controller
    {   
        private readonly moviesContext movcontext;
        public HomeController(moviesContext movcontext)
        {
            this.movcontext = movcontext;
        }

        public async Task<IActionResult> Index()
        {
            var movs = await movcontext.movies.ToListAsync();
            var content = movs.Where(i => i.ispopular == true);
            return View(content);
        }
        public async Task<IActionResult> DetailsAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movs = await movcontext.movies.ToListAsync();
            var content = movs.FirstOrDefault(i => i.id == id);
            if (content == null)
            {
                return NotFound();
            }
            return View(content);
        }
    }
}