using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class PaoController : Controller
    {
        // GET: Pao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Pao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pao/Edit/5
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

        // GET: Pao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pao/Delete/5
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
