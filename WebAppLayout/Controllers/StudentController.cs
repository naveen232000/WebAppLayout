using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLayout.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.msg = "Student Home Page";
            return View();
        }
        public ActionResult NameList() {
        List<string> list = new List<string>() { 
        "Naveen","Jon","Sam","Leo","Fiz"
        };
            ViewBag.list = list;
            return View();
        }
    }
}