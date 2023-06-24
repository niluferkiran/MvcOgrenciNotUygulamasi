using Microsoft.Ajax.Utilities;
using MvcOgrenciNotUygulamasi.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOgrenciNotUygulamasi.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var ogrenciler = db.TBLOGRENCILER.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgrenci(TBLOGRENCILER ogr)
        {
            db.TBLOGRENCILER.Add(ogr);
            db.SaveChanges();
            return View();
        }
    }
}