using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google_Pie_Chart_Report_App.Models;

namespace Google_Pie_Chart_Report_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PieChart()
        {
            return View();
        }

        public JsonResult GetPiechartJSON()
        {
            List<BlogPieChart> list = new List<BlogPieChart>();
            using (var context = new TestDBEntities())
            {
                list = context.tblPieCharts.Select(a => new BlogPieChart { CategoryName = a.CategoryName, PostCount = a.PostCount }).ToList();

            }

            return Json(new { JSONList = list }, JsonRequestBehavior.AllowGet);
        }
    }
}