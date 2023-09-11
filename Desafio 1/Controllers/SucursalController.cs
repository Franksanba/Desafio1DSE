using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Desafio_1.Models;

namespace Desafio_1.Controllers
{
    public class SucursalController : Controller
    {
        private FarmaciaDBContext db = new FarmaciaDBContext();

        // GET: Sucursal
        public ActionResult Index()
        {
            return View(db.Sucursales.ToList());
        }

        // GET: Sucursal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // GET: Sucursal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursal/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más Details, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Departamento,Municipio,EncargadoSucursal")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Sucursales.Add(sucursal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sucursal);
        }

        // GET: Sucursal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursal/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más Details, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Departamento,Municipio,EncargadoSucursal")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sucursal);
        }

        // GET: Sucursal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal sucursal = db.Sucursales.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        // POST: Sucursal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sucursal sucursal = db.Sucursales.Find(id);
            db.Sucursales.Remove(sucursal);
            db.SaveChanges();
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
