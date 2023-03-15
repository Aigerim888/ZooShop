using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooShop.Models;

namespace ZooShop.Controllers
{
    public class StorageesController : Controller
    {
        private readonly ZooShopContext _context;

        public StorageesController(ZooShopContext context)
        {
            _context = context;
        }

        // GET: Storagees
        public async Task<IActionResult> Index()
        {
            var zooShopContext = _context.Storagees.Include(s => s.Department);
            return View(await zooShopContext.ToListAsync());
        }

        // GET: Storagees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Storagees == null)
            {
                return NotFound();
            }

            var storagees = await _context.Storagees
                .Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.Storage_id == id);
            if (storagees == null)
            {
                return NotFound();
            }

            return View(storagees);
        }

        // GET: Storagees/Create
        public IActionResult Create()
        {
            ViewData["Department_id"] = new SelectList(_context.Departments, "Department_id", "Department_id");
            return View();
        }

        // POST: Storagees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Storage_id,Storage_name,The_rest_of_goods,Department_id")] Storagees storagees)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storagees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Department_id"] = new SelectList(_context.Departments, "Department_id", "Department_id", storagees.Department_id);
            return View(storagees);
        }

        // GET: Storagees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Storagees == null)
            {
                return NotFound();
            }

            var storagees = await _context.Storagees.FindAsync(id);
            if (storagees == null)
            {
                return NotFound();
            }
            ViewData["Department_id"] = new SelectList(_context.Departments, "Department_id", "Department_id", storagees.Department_id);
            return View(storagees);
        }

        // POST: Storagees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Storage_id,Storage_name,The_rest_of_goods,Department_id")] Storagees storagees)
        {
            if (id != storagees.Storage_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storagees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StorageesExists(storagees.Storage_id))
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
            ViewData["Department_id"] = new SelectList(_context.Departments, "Department_id", "Department_id", storagees.Department_id);
            return View(storagees);
        }

        // GET: Storagees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Storagees == null)
            {
                return NotFound();
            }

            var storagees = await _context.Storagees
                .Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.Storage_id == id);
            if (storagees == null)
            {
                return NotFound();
            }

            return View(storagees);
        }

        // POST: Storagees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Storagees == null)
            {
                return Problem("Entity set 'ZooShopContext.Storagees'  is null.");
            }
            var storagees = await _context.Storagees.FindAsync(id);
            if (storagees != null)
            {
                _context.Storagees.Remove(storagees);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StorageesExists(int id)
        {
          return (_context.Storagees?.Any(e => e.Storage_id == id)).GetValueOrDefault();
        }
    }
}
