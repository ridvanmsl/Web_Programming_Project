using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAssignment.Context;
using WebAssignment.Models;
using WebAssignment.ViewModels;

namespace WebAssignment.Controllers
{
    public class HomeController : Controller
    {   
        private readonly moviesContext movcontext;
        private readonly newsContext newscontext;
        public HomeController(moviesContext movcontext, newsContext newscontext)
        {
            this.movcontext = movcontext;
            this.newscontext = newscontext;
        }
        public async Task<IActionResult> Index()
        {
            var movs = await movcontext.movies.ToListAsync();
            var content = movs.Where(i => i.ispopular == true);
            var _news = await newscontext.news.ToListAsync();

            var vwmodel = new viewmodel();
            vwmodel.mvs = content;
            vwmodel.nws = _news;
            return View(vwmodel);
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