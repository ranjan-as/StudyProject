using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyProject.Controllers
{
    public class LearnController : Controller
    {
        // GET: Learn
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(FormCollection form)
        {
            string one, two;
            try {
                one = form["txtOne"];
                two = form["txtTwo"];
                int a, b, r;
                a = Convert.ToInt32(one);
                b = Convert.ToInt32(two);
                r = a + b;
                ViewBag.One = r;
            }
            catch (FormatException ex){
                ViewBag.One = ex.ToString();//"wrong input";
            }
            
            return View(form);
        }
        public ActionResult Fact() { 
        return View();
        }
        [HttpPost]
        public ActionResult Fact(FormCollection form) {
            string st = form["txtNo"];
            double r = 1;
            int n = 0;

            try
            {
                n = Convert.ToInt32(st);
                if (n > 0)
                {
                    if (n == 0 || n == 1)
                    {
                        TempData["r"] = r.ToString();
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            r = r * i;
                        }
                        TempData["r"] = r.ToString();
                    }
                }
                else
                {
                    TempData["r"] = "Negative integer not allowed";
                }
            }
            catch (FormatException ex)
            {
                TempData["r"] = ex.ToString();
            }
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Sub() 
            {
            return View();
            }
        [HttpPost]
        public ActionResult Sub(FormCollection form)
        {
            int a, b, c;           
            string first = form["txtOne"];
            string second = form["txtTwo"];
            try
            {
                a = Convert.ToInt32(first);
                b = Convert.ToInt32(second);
                c = a - b;

                
                TempData["r"] = c.ToString();
            }
            catch (FormatException ex) {
                TempData["r"] = ex.ToString();
            }


            return View();
        }
    }
}