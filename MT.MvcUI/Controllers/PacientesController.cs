using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MT.Entities;

namespace MT.MvcUI.Controllers
{
    public class PacientesController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            var lis = new List<Pacientes>();

            return View(lis);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}