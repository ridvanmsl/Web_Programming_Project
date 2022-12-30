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
            var popmovs = await movcontext.movies.ToListAsync();
            var content = popmovs.Where(i => i.ispopular == true);
            var _news = await newscontext.news.ToListAsync();
            var movs = await movcontext.movies.ToListAsync();
            var movcontent = movs.Where(i => i.isOut == true);
            var willoutmovs = await movcontext.movies.ToListAsync();
            var willoutmovscontent = willoutmovs.Where(i => i.isOut == false);


            var vwmodel = new viewmodel();
            vwmodel.popmvs = content;
            vwmodel.nws = _news;
            vwmodel.mvs = movcontent;
            vwmodel.willoutmovs = willoutmovscontent;
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