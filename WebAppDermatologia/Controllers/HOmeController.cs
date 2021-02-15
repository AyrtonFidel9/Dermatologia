using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDermatologia.Controllers
{
    public class HOmeController : Controller
    {
        // GET: HOme
        public ActionResult Inicio()
        {
            return View();
        }

       

        public ActionResult Empleado()
        {
            return View();
        }

        public ActionResult Citas()
        {
            return View();
        }

        // GET: HOme/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HOme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HOme/Create
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

        // GET: HOme/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HOme/Edit/5
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

        // GET: HOme/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HOme/Delete/5
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
