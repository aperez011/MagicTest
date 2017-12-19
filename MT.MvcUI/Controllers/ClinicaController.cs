using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MT.Entities;
using MT.Services;

namespace MT.MvcUI.Controllers
{
    public class ClinicaController : Controller
    {
        // GET: Clinica
        public ActionResult Index()
        {
            //var clincs = ClinicaServices.Current.GetAll();
            var clincs = new List<Clinica>();

            return View(clincs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Clinica cl)
        {

            cl.IsActive = true;
            cl.LogDate = DateTime.Now;

            if (ClinicaServices.Current.Save(cl))
            {
                return RedirectToAction("Index");
            }
            else
            {

                return View(cl);
            }
        }
    }
}