using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPong.Models;
using System;

namespace PingPong.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/result")]
      public ActionResult Result()
      {
        PingPongGenerator newNum = new PingPongGenerator();
        List<string> result = newNum.GetResult(Int32.Parse(Request.Form["new-game"]));
        return View(result);
      }
  }
}
