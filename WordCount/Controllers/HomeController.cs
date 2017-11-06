using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/CountPage")]
      public ActionResult CountPage()
      {
        // RepeatCounter repeats = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
        // // repeats.Save();
        // return View(repeats);
      //
        int repeats = RepeatCounter.CountRepeats(Request.Form["sentence"], Request.Form["word"]);
        
        return View(repeats);

        // RepeatCounter string repeats = new RepeatCounter.CountRepeats(RequestForm.["sentence"], RequestForm["word"]);
        //
        // return View(repeats);
      }
    }
}
