using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;
using TestFormApp;

namespace TestWeb
{
    public class tbl_ProductsController : Controller
    {
        private TestMvcDBEntities db = new TestMvcDBEntities();

        // GET: tbl_Products
        public async Task<ActionResult> Index()
        {
            return View(await db.tbl_Products.ToListAsync());
        }

        // GET: tbl_Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Products tbl_Products = await db.tbl_Products.FindAsync(id);
            if (tbl_Products == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Products);
        }

        // GET: tbl_Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Product_ID,Product_Name,Product_Design,Product_Color,Product_Warranty,CreatedAt")] tbl_Products tbl_Products)
        {
            if (ModelState.IsValid)
            {
                //db.tbl_Products.Add(tbl_Products);
                //await db.SaveChangesAsync();
                FormFunction.addProducts(tbl_Products.Product_ID, tbl_Products.Product_Name, tbl_Products.Product_Design, tbl_Products.Product_Color, tbl_Products.Product_Warranty, tbl_Products.CreatedAt);
                return RedirectToAction("Index");
            }

            return View(tbl_Products);
        }

        // GET: tbl_Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Products tbl_Products = await db.tbl_Products.FindAsync(id);
            if (tbl_Products == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Products);
        }

        // POST: tbl_Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Product_ID,Product_Name,Product_Design,Product_Color,Product_Warranty,CreatedAt")] tbl_Products tbl_Products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Products).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tbl_Products);
        }

        // GET: tbl_Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Products tbl_Products = await db.tbl_Products.FindAsync(id);
            if (tbl_Products == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Products);
        }

        // POST: tbl_Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //tbl_Products tbl_Products = await db.tbl_Products.FindAsync(id);
            //db.tbl_Products.Remove(tbl_Products);
            //await db.SaveChangesAsync();
            FormFunction.deleteProduct(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
