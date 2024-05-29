using Admission_Form.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admission_Form.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContext Db = new StudentDbContext();
        public ActionResult Index(Student std)
        {

            return View(Db.Students.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            Db.Students.Add(std);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            if(id<0)
            {
                return View("Bad Request");
            }
            var std = Db.Students.Where(m => m.Id == id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                Db.Entry(std).State = EntityState.Modified;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id < 0)
            {
                return View("Bad Request");
            }
            var std = Db.Students.Where(m => m.Id == id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Student std)
        {
              Db.Entry(std).State=EntityState.Deleted;
            Db.SaveChanges();
              return RedirectToAction("Index");
            
        }
    }
}