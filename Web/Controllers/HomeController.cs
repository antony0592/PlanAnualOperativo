using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Application.Main.Interfaces;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PAO_Objetivo PAO_Objetivo;
        private readonly PAO_Meta PAO_Meta;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Objetivos()
        {
            return View();
        }

        public ActionResult Metas()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarObjetivo(PaoView datosvista)
        {

            PaoView delitoView = new PaoView()
            {
                
            };

            return View();
        }

        [HttpPost]
        public ActionResult GuardarObjetivo(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
