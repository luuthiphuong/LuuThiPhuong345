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
    public class PersonLTP345sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonLTP345sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonLTP345s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonLTP345.ToListAsync());
        }

        // GET: PersonLTP345s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTP345 = await _context.PersonLTP345
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personLTP345 == null)
            {
                return NotFound();
            }

            return View(personLTP345);
        }

        // GET: PersonLTP345s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonLTP345s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonLTP345 personLTP345)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personLTP345);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personLTP345);
        }

        // GET: PersonLTP345s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTP345 = await _context.PersonLTP345.FindAsync(id);
            if (personLTP345 == null)
            {
                return NotFound();
            }
            return View(personLTP345);
        }

        // POST: PersonLTP345s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonLTP345 personLTP345)
        {
            if (id != personLTP345.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personLTP345);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonLTP345Exists(personLTP345.PersonId))
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
            return View(personLTP345);
        }

        // GET: PersonLTP345s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTP345 = await _context.PersonLTP345
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personLTP345 == null)
            {
                return NotFound();
            }

            return View(personLTP345);
        }

        // POST: PersonLTP345s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personLTP345 = await _context.PersonLTP345.FindAsync(id);
            _context.PersonLTP345.Remove(personLTP345);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonLTP345Exists(int id)
        {
            return _context.PersonLTP345.Any(e => e.PersonId == id);
        }
    }
}
