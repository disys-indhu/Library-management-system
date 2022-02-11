using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIBRARY_MANAGEMENT.Models;

namespace LIBRARY_MANAGEMENT.Controllers
{
    public class BTController : Controller
    {
        // GET: BT
        public ActionResult Index()
        {
            using (appdev_trainingEntities app = new appdev_trainingEntities())
            {
                return View(app.Borrower_Table.ToList());
            }
                
        }
        public ActionResult Details(int id)
        {
            using (appdev_trainingEntities app = new appdev_trainingEntities())
            {
                return View(app.Borrower_Table.Where(x => x.Borrower_Id == id).FirstOrDefault());
            }

        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Library_Book_Details/Create
        [HttpPost]
        public ActionResult Create(Borrower_Table borrower_Table)
        {
            try
            {
                using (appdev_trainingEntities app = new appdev_trainingEntities())
                {
                    app.Borrower_Table.Add(borrower_Table);
                    app.SaveChanges();
                }
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
            using (appdev_trainingEntities app = new appdev_trainingEntities())
            {
                return View(app.Borrower_Table.Where(x => x.Borrower_Id == id).FirstOrDefault());
            }
        }

        // POST: Library_Book_Details/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Borrower_Table borrower_Table)
        {
            try
            {
                using (appdev_trainingEntities app = new appdev_trainingEntities())
                {
                    app.Entry(borrower_Table).State = EntityState.Modified;
                    app.SaveChanges();
                }
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
            using (appdev_trainingEntities app = new appdev_trainingEntities())
            {
                return View(app.Borrower_Table.Where(x => x.Borrower_Id == id).FirstOrDefault());
            }
        }

        // POST: Library_Book_Details/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (appdev_trainingEntities app = new appdev_trainingEntities())
                {
                    Borrower_Table borrower_Table = app.Borrower_Table.Where(x => x.Borrower_Id == id).FirstOrDefault();
                    app.Borrower_Table.Remove(borrower_Table);
                    app.SaveChanges();
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