using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ltt_231230910_de01.Models;

namespace ltt_231230910_de01.Controllers
{
    public class LttComputersController : Controller
    {
        private readonly Ltt_231230910_de01DBContext _context;

        public LttComputersController(Ltt_231230910_de01DBContext context)
        {
            _context = context;
        }

        // GET: LttComputers
        public async Task<IActionResult> LttIndex()
        {
            return View(await _context.LttComputers.ToListAsync());
        }

        // GET: LttComputers/Details/5
        public async Task<IActionResult> LttDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lttComputer = await _context.LttComputers
                .FirstOrDefaultAsync(m => m.lttComId == id);
            if (lttComputer == null)
            {
                return NotFound();
            }

            return View(lttComputer);
        }

        // GET: LttComputers/Create
        public IActionResult LttCreate()
        {
            return View();
        }

        // POST: LttComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LttCreate([Bind("lttComId,lttComName,lttComPrice,lttComImage,lttComStatus")] LttComputer lttComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lttComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LttIndex));
            }
            return View(lttComputer);
        }

        // GET: LttComputers/Edit/5
        public async Task<IActionResult> LttEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lttComputer = await _context.LttComputers.FindAsync(id);
            if (lttComputer == null)
            {
                return NotFound();
            }
            return View(lttComputer);
        }

        // POST: LttComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LttEdit(int id, [Bind("lttComId,lttComName,lttComPrice,lttComImage,lttComStatus")] LttComputer lttComputer)
        {
            if (id != lttComputer.lttComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lttComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LttComputerExists(lttComputer.lttComId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(LttIndex));
            }
            return View(lttComputer);
        }

        // GET: LttComputers/Delete/5
        public async Task<IActionResult> LttDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lttComputer = await _context.LttComputers
                .FirstOrDefaultAsync(m => m.lttComId == id);
            if (lttComputer == null)
            {
                return NotFound();
            }

            return View(lttComputer);
        }

        // POST: LttComputers/Delete/5
        [HttpPost, ActionName("LttDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lttComputer = await _context.LttComputers.FindAsync(id);
            if (lttComputer != null)
            {
                _context.LttComputers.Remove(lttComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(LttIndex));
        }

        private bool LttComputerExists(int id)
        {
            return _context.LttComputers.Any(e => e.lttComId == id);
        }
    }
}
