using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QUANLYKHO.Models;

namespace QUANLYKHO.Controllers
{
    public class PhieuNhapHangsController : Controller
    {
        private QUANLYKHOEntities db = new QUANLYKHOEntities();

        // GET: PhieuNhapHangs
        public ActionResult Index()
        {
            var phieuNhapHang = db.PhieuNhapHang.Include(p => p.TaiKhoan);
            return View(phieuNhapHang.ToList());
        }

        // GET: PhieuNhapHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhapHang phieuNhapHang = db.PhieuNhapHang.Find(id);
            if (phieuNhapHang == null)
            {
                return HttpNotFound();
            }
            return View(phieuNhapHang);
        }

        // GET: PhieuNhapHangs/Create
        public ActionResult Create()
        {
            ViewBag.maNguoiDung = new SelectList(db.TaiKhoan, "maNguoiDung", "tenDangNhap");
            return View();
        }

        // POST: PhieuNhapHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maPhieuNhap,maNguoiDung,ngayNhap,trangThai,ghiChu")] PhieuNhapHang phieuNhapHang)
        {
            if (ModelState.IsValid)
            {
                db.PhieuNhapHang.Add(phieuNhapHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.maNguoiDung = new SelectList(db.TaiKhoan, "maNguoiDung", "tenDangNhap", phieuNhapHang.maNguoiDung);
            return View(phieuNhapHang);
        }

        // GET: PhieuNhapHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhapHang phieuNhapHang = db.PhieuNhapHang.Find(id);
            if (phieuNhapHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.maNguoiDung = new SelectList(db.TaiKhoan, "maNguoiDung", "tenDangNhap", phieuNhapHang.maNguoiDung);
            ViewBag.ngayNhap = phieuNhapHang.ngayNhap.ToString("yyyy-MM-ddTHH:mm");
            return View(phieuNhapHang);
        }

        // POST: PhieuNhapHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maPhieuNhap,maNguoiDung,ngayNhap,trangThai,ghiChu")] PhieuNhapHang phieuNhapHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuNhapHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.maNguoiDung = new SelectList(db.TaiKhoan, "maNguoiDung", "tenDangNhap", phieuNhapHang.maNguoiDung);
            return View(phieuNhapHang);
        }

        // GET: PhieuNhapHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuNhapHang phieuNhapHang = db.PhieuNhapHang.Find(id);
            if (phieuNhapHang == null)
            {
                return HttpNotFound();
            }
            return View(phieuNhapHang);
        }

        // POST: PhieuNhapHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PhieuNhapHang phieuNhapHang = db.PhieuNhapHang.Find(id);
            db.PhieuNhapHang.Remove(phieuNhapHang);
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
