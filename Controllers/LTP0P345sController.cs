using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuuThiPhuong345.Models;

namespace LuuThiPhuong345.Controllers
{
    public class LTP0P345sController : Controller
    {
        private readonly ApplicationContext _context;

        public LTP0P345sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: LTP0P345s
        public async Task<IActionResult> Index()
        {
            return View(await _context.LTP0345.ToListAsync());
        }

        // GET: LTP0P345s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTP0345 = await _context.LTP0345
                .FirstOrDefaultAsync(m => m.LTPId == id);
            if (lTP0345 == null)
            {
                return NotFound();
            }

            return View(lTP0345);
        }

        // GET: LTP0P345s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LTP0P345s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LTPId,LTPName,LTPGender")] LTP0345 lTP0345)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lTP0345);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lTP0345);
        }

        // GET: LTP0P345s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTP0345 = await _context.LTP0345.FindAsync(id);
            if (lTP0345 == null)
            {
                return NotFound();
            }
            return View(lTP0345);
        }

        // POST: LTP0P345s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LTPId,LTPName,LTPGender")] LTP0345 lTP0345)
        {
            if (id != lTP0345.LTPId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lTP0345);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LTP0345Exists(lTP0345.LTPId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lTP0345);
        }

        // GET: LTP0P345s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTP0345 = await _context.LTP0345
                .FirstOrDefaultAsync(m => m.LTPId == id);
            if (lTP0345 == null)
            {
                return NotFound();
            }

            return View(lTP0345);
        }

        // POST: LTP0P345s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lTP0345 = await _context.LTP0345.FindAsync(id);
            _context.LTP0345.Remove(lTP0345);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LTP0345Exists(int id)
        {
            return _context.LTP0345.Any(e => e.LTPId == id);
        }
    }
}
