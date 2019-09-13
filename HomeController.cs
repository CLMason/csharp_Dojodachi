using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public static Datchi datchi = new Datchi ();
       

        [HttpGet("")]
        public IActionResult Index()
        {
            datchi._CheckGameOver();
            return View(datchi);
        }
        [HttpGet("feed")]
        public IActionResult Feed()
        {
            datchi.Feed();
            return Redirect("/");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            datchi.Play();
            return Redirect("/");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            datchi.Sleep();
            return Redirect("/");
        }
         [HttpGet("work")]
        public IActionResult Work()
        {
            datchi.Work();
            return Redirect("/");
        }
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            datchi = new Datchi();
            return Redirect("/");
        }
    }
}

   
