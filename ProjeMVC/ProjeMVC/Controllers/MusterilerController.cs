using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeMVC.Models.Entity;

namespace ProjeMVC.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TblMusteriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TblMusteriler p1)
        {
            db.TblMusteriler.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var musteri = db.TblMusteriler.Find(id);
            db.TblMusteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}