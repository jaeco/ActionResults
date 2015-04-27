using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionResults.Models;

namespace ActionResults.Controllers
{
    public class HomeController : Controller
    {
        Character jon = new Character();
        
        //Main page
        public ActionResult Index()
        {
            jon.Name = "John";
            jon.Level = 12;
            jon.HealthPoints = 200;
            return View(jon);

        }

        //String page
        public String StringPage()
        {
            return jon.ToString();

        }

        //XML Page

        //JSON Page

        //Error 404

        //Download
    }
}