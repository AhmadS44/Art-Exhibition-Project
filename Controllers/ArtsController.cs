using Art_Exhibition_Project;
using Art_Exhibition_Project.Models;
using ArtExhibitionProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Art_Exhibition_Project.Controllers
{
    public class ArtsController : Controller
    {
        private readonly Context _context;

        public ArtsController(Context context)
        {
            _context = context;
        }

        // GET: Arts
        public async Task<IActionResult> Index(
    string sortOrder,
    string currentFilter,
    string searchString,
    int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var art = _context.Art.Include(a => a.Artist).AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                art = art.Where(a => a.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    art = art.OrderByDescending(s => s.Title);
                    break;
                
                default:
                    art = art.OrderBy(s => s.Title);
                    break;
            }

            int pageSize = 5;
            return View(await PaginatedList<Art>.CreateAsync(art.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        
        

        // GET: Arts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var art = await _context.Art
                .Include(a => a.Artist)
                .FirstOrDefaultAsync(m => m.ArtId == id);
            if (art == null)
            {
                return NotFound();
            }

            return View(art);
        }

        // GET: Arts/Create
        [Authorize]

        public IActionResult Create()
        {
            ViewData["ArtistID"] = new SelectList(_context.Set<Artist>(), "ArtistID", "ArtistID");
            return View();
        }

        // POST: Arts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("ArtId,ArtistID,Title,Price,Description")] Art art)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(art);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.Set<Artist>(), "ArtistID", "ArtistID", art.ArtistID);
            return View(art);
        }

        // GET: Arts/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var art = await _context.Art.FindAsync(id);
            if (art == null)
            {
                return NotFound();
            }
            ViewData["ArtistID"] = new SelectList(_context.Set<Artist>(), "ArtistID", "ArtistID", art.ArtistID);
            return View(art);
        }

        // POST: Arts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ArtId,ArtistID,Title,Price,Description")] Art art)
        {
            if (id != art.ArtId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(art);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtExists(art.ArtId))
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
            ViewData["ArtistID"] = new SelectList(_context.Set<Artist>(), "ArtistID", "ArtistID", art.ArtistID);
            return View(art);
        }

        // GET: Arts/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var art = await _context.Art
                .Include(a => a.Artist)
                .FirstOrDefaultAsync(m => m.ArtId == id);
            if (art == null)
            {
                return NotFound();
            }

            return View(art);
        }

        // POST: Arts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var art = await _context.Art.FindAsync(id);
            if (art != null)
            {
                _context.Art.Remove(art);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtExists(int id)
        {
            return _context.Art.Any(e => e.ArtId == id);
        }
    }
}
