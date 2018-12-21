using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DWD273_W5_L3_CrawJessica.Models;

namespace DWD273_W5_L3_CrawJessica.Controllers
{
    public class RandNumsController : Controller
    {
        private RandNumDB db = new RandNumDB();

        // GET: RandNums
        public async Task<ActionResult> Index()
        {
            return View(await db.RandNums.ToListAsync());
        }

        

        // GET: RandNums/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RandNum randNum = await db.RandNums.FindAsync(id);
            if (randNum == null)
            {
                return HttpNotFound();
            }
            return View(randNum);
        }

        // GET: RandNums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RandNums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,LgRandNum,SmRandNum")] RandNum randNum)
        {
            if (ModelState.IsValid)
            {
                db.RandNums.Add(randNum);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(randNum);
        }

        // GET: RandNums/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RandNum randNum = await db.RandNums.FindAsync(id);
            if (randNum == null)
            {
                return HttpNotFound();
            }
            return View(randNum);
        }

        // POST: RandNums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,LgRandNum,SmRandNum")] RandNum randNum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(randNum).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(randNum);
        }

        // GET: RandNums/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RandNum randNum = await db.RandNums.FindAsync(id);
            if (randNum == null)
            {
                return HttpNotFound();
            }
            return View(randNum);
        }

        // POST: RandNums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RandNum randNum = await db.RandNums.FindAsync(id);
            db.RandNums.Remove(randNum);
            await db.SaveChangesAsync();
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
