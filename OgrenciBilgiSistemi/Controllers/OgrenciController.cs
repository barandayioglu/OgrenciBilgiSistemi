using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OgrenciBilgiSistemi.Controllers
{
    public class OgrenciController : Controller
    {
        private OgrenciManager _ogrenciManager = new OgrenciManager();

        public ActionResult Index()
        {
            return View(_ogrenciManager.List());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _ogrenciManager.Find(x => x.Id == id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _ogrenciManager.Insert(ogrenci);
                _ogrenciManager.Save();
                return RedirectToAction("Index");
            }
            return View(ogrenci);

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _ogrenciManager.Find(x => x.Id == id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _ogrenciManager.Update(ogrenci);
                _ogrenciManager.Save();
                return RedirectToAction("Index");
            }
            return View(ogrenci);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _ogrenciManager.Find(x => x.Id == id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrenci ogrenci = _ogrenciManager.Find(x => x.Id == id);
            _ogrenciManager.Delete(ogrenci);
            _ogrenciManager.Save();
            return RedirectToAction("Index");
        }

    }
}


   