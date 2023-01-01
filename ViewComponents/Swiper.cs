using System;
using Microsoft.AspNetCore.Mvc;
using WebAssignment.Models;

namespace WebAssignment.ViewComponents
{
    public class Swiper:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var swiper = new List<movies> { 
        
            new movies
            {
                id = 6,
                name = "The Batman",
                summary = "Zoom Into The Darkness",
                bigmovimg = "img/hero.jpg"
            },
            new movies
            {
                id = 33,
                name = "Doctor Strange in the Multiverse of Madness",
                summary = "Multiverse of Madness",
                bigmovimg = "img/hero2.jpg"
            },
            new movies
            {
                id = 10,
                name = "Dune",
                summary = "Planet Of Desert",
                bigmovimg = "img/hero3.jpg"
            }
        };
            return View(swiper);
        }
    }
}

