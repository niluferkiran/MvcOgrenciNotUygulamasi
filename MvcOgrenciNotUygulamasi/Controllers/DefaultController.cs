﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOgrenciNotUygulamasi.Models.EntityFramework;

namespace MvcOgrenciNotUygulamasi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var dersler = db.TBLDERSLER.ToList();
            return View(dersler);
        }
        [HttpGet]
        public ActionResult YeniDers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDers(TBLDERSLER p)
        {
            db.TBLDERSLER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
    
}