using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIBRARY_MANAGEMENT.Models;

namespace LIBRARY_MANAGEMENT.Controllers
{
    public class indhuController : Controller
    {
        // GET: indhu
        public ActionResult Index()
        {
            using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
            {
                return View(app1.Indhu_Book.ToList());
            }
        }

        // GET: indhu/Details/5
        public ActionResult Details(int id)
        {
            using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
            {
                return View(app1.Indhu_Book.Where(x => x.BookId == id).FirstOrDefault());
            }
        }

        // GET: indhu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: indhu/Create
        [HttpPost]
        public ActionResult Create(Indhu_Book indhu_Book)
        {
            try
            {
                using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
                {
                    app1.Indhu_Book.Add(indhu_Book);
                    app1.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: indhu/Edit/5
        public ActionResult Edit(int id)
        {
            using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
            {
                return View(app1.Indhu_Book.Where(x => x.BookId == id).FirstOrDefault());
            }
        }

        // POST: indhu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Indhu_Book indhu_Book)
        {
            try
            {
                using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
                {
                    app1.Entry(indhu_Book).State = EntityState.Modified;
                    app1.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: indhu/Delete/5
        public ActionResult Delete(int id)
        {
            using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
            {
                return View(app1.Indhu_Book.Where(x => x.BookId == id).FirstOrDefault());
            }
        }

        // POST: Library_Book_Details/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (appdev_trainingEntities1 app1 = new appdev_trainingEntities1())
                {
                    Indhu_Book indhu_Book = app1.Indhu_Book.Where(x => x.BookId == id).FirstOrDefault();
                    app1.Indhu_Book.Remove(indhu_Book);
                    app1.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
