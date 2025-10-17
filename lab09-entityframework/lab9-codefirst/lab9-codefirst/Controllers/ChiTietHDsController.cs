using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab9_codefirst.Models;

namespace lab9_codefirst.Controllers
{
    public class ChiTietHDsController : Controller
    {
        private readonly ShoppingCartDBContext _context;

        public ChiTietHDsController(ShoppingCartDBContext context)
        {
            _context = context;
        }

        // GET: ChiTietHDs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietHDs.ToListAsync());
        }

        // GET: ChiTietHDs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHDs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietHD == null)
            {
                return NotFound();
            }

            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiTietHDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaHoaDon,MaSP,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] ChiTietHD chiTietHD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHDs.FindAsync(id);
            if (chiTietHD == null)
            {
                return NotFound();
            }
            return View(chiTietHD);
        }

        // POST: ChiTietHDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaHoaDon,MaSP,SoLuongMua,DonGiaMua,ThanhTien,TrangThai")] ChiTietHD chiTietHD)
        {
            if (id != chiTietHD.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHDExists(chiTietHD.Id))
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
            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHDs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chiTietHD == null)
            {
                return NotFound();
            }

            return View(chiTietHD);
        }

        // POST: ChiTietHDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHD = await _context.ChiTietHDs.FindAsync(id);
            if (chiTietHD != null)
            {
                _context.ChiTietHDs.Remove(chiTietHD);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHDExists(int id)
        {
            return _context.ChiTietHDs.Any(e => e.Id == id);
        }
    }
}
