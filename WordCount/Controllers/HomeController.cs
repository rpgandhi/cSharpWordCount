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
    }
}
