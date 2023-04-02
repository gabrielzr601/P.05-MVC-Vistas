using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class Estados_equiposController : Controller
    {
        private readonly equiposDbContext _context;

        public Estados_equiposController(equiposDbContext context)
        {
            _context = context;
        }

        // GET: Estados_equipos
        public async Task<IActionResult> Index()
        {
              return _context.estados_equipo != null ? 
                          View(await _context.estados_equipo.ToListAsync()) :
                          Problem("Entity set 'equiposDbContext.estados_equipo'  is null.");
        }

        // GET: Estados_equipos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.estados_equipo == null)
            {
                return NotFound();
            }

            var estados_equipos = await _context.estados_equipo
                .FirstOrDefaultAsync(m => m.id_estados_equipo == id);
            if (estados_equipos == null)
            {
                return NotFound();
            }

            return View(estados_equipos);
        }

        // GET: Estados_equipos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estados_equipos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_estados_equipo,descripcion,estado")] Estados_equipos estados_equipos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estados_equipos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estados_equipos);
        }

        // GET: Estados_equipos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.estados_equipo == null)
            {
                return NotFound();
            }

            var estados_equipos = await _context.estados_equipo.FindAsync(id);
            if (estados_equipos == null)
            {
                return NotFound();
            }
            return View(estados_equipos);
        }

        // POST: Estados_equipos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_estados_equipo,descripcion,estado")] Estados_equipos estados_equipos)
        {
            if (id != estados_equipos.id_estados_equipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estados_equipos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Estados_equiposExists(estados_equipos.id_estados_equipo))
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
            return View(estados_equipos);
        }

        // GET: Estados_equipos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.estados_equipo == null)
            {
                return NotFound();
            }

            var estados_equipos = await _context.estados_equipo
                .FirstOrDefaultAsync(m => m.id_estados_equipo == id);
            if (estados_equipos == null)
            {
                return NotFound();
            }

            return View(estados_equipos);
        }

        // POST: Estados_equipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.estados_equipo == null)
            {
                return Problem("Entity set 'equiposDbContext.estados_equipo'  is null.");
            }
            var estados_equipos = await _context.estados_equipo.FindAsync(id);
            if (estados_equipos != null)
            {
                _context.estados_equipo.Remove(estados_equipos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Estados_equiposExists(int id)
        {
          return (_context.estados_equipo?.Any(e => e.id_estados_equipo == id)).GetValueOrDefault();
        }
    }
}
