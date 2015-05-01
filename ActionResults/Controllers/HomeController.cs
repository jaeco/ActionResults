using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
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
            jon.Name = "John Jingleheimershcmidt";
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
        public ActionResult XMLPage()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Character));
            string xmlString;
            using (var sw = new StringWriter())
            {
                using (var writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                    serializer.WriteObject(writer, jon);
                    writer.Flush();
                    xmlString = sw.ToString();
                    return this.Content(xmlString, "text/xml");
                }
            }
        }

        //JSON Page
        public ActionResult JSONPage()
        {
            return Json(jon, JsonRequestBehavior.AllowGet);
        }
        //Error 404
        public ActionResult ErrorPage()
        {
            return HttpNotFound("Gurl, you dun got a 404 hunny!");
        }
        //Download
        public ActionResult DownloadPage()
        {
            var ImagePath = Server.MapPath("~/Images/funny.jpg");
            Response.AddHeader("Content-Disposition", "attachment;filename=funny.jpg");
            Response.WriteFile(ImagePath);
            Response.End();
            return null;
        }
    }
}