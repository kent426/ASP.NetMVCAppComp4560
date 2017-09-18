using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowFiles.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            Array.Sort(files);
            return View(files);
        }

        public ActionResult Filecontent(string filename)
        {
            var filepath = Server.MapPath($"~/TextFiles/{filename}.txt");
            string c;
            if (System.IO.File.Exists(filepath))
            {
                c = System.IO.File.ReadAllText(filepath);
                
            } else
            {
                c = "File Not Found";
            }
            
            return View((object)c);
            
                
            
        }
    }
}