using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIBRARY_MANAGEMENT.Models;

namespace LIBRARY_MANAGEMENT.Controllers
{
    public class Library_Book_DetailsController : Controller
    {
        // GET: Library_Book_Details
        public ActionResult Index()
        {
            using(DBModels dbmodels = new DBModels())
            {
                return View(dbmodels.Library_Book_Details.ToList());
            }
               
        }

        // GET: Library_Book_Details/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels dbmodels = new DBModels())
            {
                return View(dbmodels.Library_Book_Details.Where(x => x.Book_ID == id).FirstOrDefault());
            }
               
        }

        // GET: Library_Book_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Library_Book_Details/Create
        [HttpPost]
        public ActionResult Create(Library_Book_Details library_book_details)
        {
            try
            {
                using(DBModels dbmodels = new DBModels())
                {
                    dbmodels.Library_Book_Details.Add(library_book_details);
                    dbmodels.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Library_Book_Details/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels dbmodels = new DBModels())
            {
                return View(dbmodels.Library_Book_Details.Where(x => x.Book_ID == id).FirstOrDefault());
            }
        }

        // POST: Library_Book_Details/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Library_Book_Details library_Book_Details)
        {
            try
            {
                using (DBModels dbmodels = new DBModels())
                {
                    dbmodels.Entry(library_Book_Details).State = EntityState.Modified;
                    dbmodels.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Library_Book_Details/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels dbmodels = new DBModels())
            {
                return View(dbmodels.Library_Book_Details.Where(x => x.Book_ID == id).FirstOrDefault());
            }
        }

        // POST: Library_Book_Details/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using(DBModels dbmodels = new DBModels())
                {
                    Library_Book_Details library_Book_Details = dbmodels.Library_Book_Details.Where(x => x.Book_ID == id).FirstOrDefault();
                    dbmodels.Library_Book_Details.Remove(library_Book_Details);
                    dbmodels.SaveChanges();
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
