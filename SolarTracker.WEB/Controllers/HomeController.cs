using SolarTracker.BL;
using SolarTracker.DAL;
using SolarTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolarTracker.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string value)
        {
            SensorsService s = new SensorsService();
            s.PublishString("1:3:02/03/1993 12/12/12:25:25:02/03/1993 12/12/12:26:26:02/03/1993 12/12/12:27:27:112");
            IList<SensorsDatum> v = s.GetData();
            //Int32 l = v.Count;
            //ViewBag.Message = "ToString(v[l-1][1])";
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
    }
}