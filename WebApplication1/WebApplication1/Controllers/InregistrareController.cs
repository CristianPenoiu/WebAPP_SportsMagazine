using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="User")]
    public class InregistrareController : Controller
    {
        private readonly WebSportsAppDbContext _context;

        public InregistrareController(WebSportsAppDbContext context)
        {
            _context = context;
        }

        // GET: Inregistrare
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inregistrare.ToListAsync());
        }

        // GET: Inregistrare/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inregistrare = await _context.Inregistrare
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inregistrare == null)
            {
                return NotFound();
            }

            return View(inregistrare);
        }

        // GET: Inregistrare/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inregistrare/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Source")] Inregistrare inregistrare)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inregistrare);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inregistrare);
        }

        // GET: Inregistrare/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inregistrare = await _context.Inregistrare.FindAsync(id);
            if (inregistrare == null)
            {
                return NotFound();
            }
            return View(inregistrare);
        }

        // POST: Inregistrare/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Source")] Inregistrare inregistrare)
        {
            if (id != inregistrare.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inregistrare);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InregistrareExists(inregistrare.Id))
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
            return View(inregistrare);
        }

        // GET: Inregistrare/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inregistrare = await _context.Inregistrare
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inregistrare == null)
            {
                return NotFound();
            }

            return View(inregistrare);
        }

        // POST: Inregistrare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inregistrare = await _context.Inregistrare.FindAsync(id);
            if (inregistrare != null)
            {
                _context.Inregistrare.Remove(inregistrare);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InregistrareExists(int id)
        {
            return _context.Inregistrare.Any(e => e.Id == id);
        }
    }
}
