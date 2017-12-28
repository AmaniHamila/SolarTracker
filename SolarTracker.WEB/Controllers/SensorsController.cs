using SolarTracker.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace SolarTracker.WEB.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    public class SensorsController : Controller
    {
        // GET: Sensors
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public void e([FromBody]String value)
        {
            value = System.Web.HttpContext.Current.Request.Params["e"];
            //value id:N:date1:tem1:hum1:date2:tem2:hum2:...:CRC
            if (value != null)
            {
                SensorsService s = new SensorsService();
                s.PublishString(value);
            }

        }
    }
}