﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpaceCat;
using SpaceCat.Data;

namespace SpaceCat.Controllers
{
    public class MackaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MackaController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "user")]
        // GET: Macka
        public async Task<IActionResult> Index()
        {
            return View(await _context.Macka.ToListAsync());
        }
        [Authorize(Roles = "admin")]
        // GET: Macka/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macka = await _context.Macka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (macka == null)
            {
                return NotFound();
            }

            return View(macka);
        }
        [Authorize(Roles = "admin")]
        // GET: Macka/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        // POST: Macka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,KorisnickoIme,Lozinka,ImeVlasnika,ImeMacke,Drzava,Pol,DobMacke,ZdravaMacka,Slika,Paket,Odabrana,OdabranaRanije,VjerovatnocaOdabira,Kompetentna")] Macka macka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(macka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(macka);
        }
        [Authorize(Roles = "admin")]
        // GET: Macka/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macka = await _context.Macka.FindAsync(id);
            if (macka == null)
            {
                return NotFound();
            }
            return View(macka);
        }
        [Authorize(Roles = "admin")]
        // POST: Macka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,KorisnickoIme,Lozinka,ImeVlasnika,ImeMacke,Drzava,Pol,DobMacke,ZdravaMacka,Slika,Paket,Odabrana,OdabranaRanije,VjerovatnocaOdabira,Kompetentna")] Macka macka)
        {
            if (id != macka.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(macka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MackaExists(macka.ID))
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
            return View(macka);
        }
        [Authorize(Roles = "admin")]
        // GET: Macka/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macka = await _context.Macka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (macka == null)
            {
                return NotFound();
            }

            return View(macka);
        }
        [Authorize(Roles = "admin")]
        // POST: Macka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var macka = await _context.Macka.FindAsync(id);
            _context.Macka.Remove(macka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MackaExists(int id)
        {
            return _context.Macka.Any(e => e.ID == id);
        }
    }
}
