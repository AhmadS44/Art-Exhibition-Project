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
    public class ExhibitionsController : Controller
    {
        private readonly Context _context;

        public ExhibitionsController(Context context)
        {
            _context = context;
        }

        // GET: Exhibitions
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["GalleryNameSortParm"] = sortOrder == "galleryname" ? "galleryname_desc" : "galleryname";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var exhibitions = _context.Exhibition.AsQueryable();

            // Apply search filter
            if (!string.IsNullOrEmpty(searchString))
            {
                exhibitions = exhibitions.Where(e => e.GalleryName.Contains(searchString));
            }

            // Apply sorting
            switch (sortOrder)
            {
                case "galleryname_desc":
                    exhibitions = exhibitions.OrderByDescending(e => e.GalleryName);
                    break;
                default:
                    exhibitions = exhibitions.OrderBy(e => e.GalleryName);
                    break;
            }

            // Pagination
            int pageSize = 5;
            return View(await PaginatedList<Exhibition>.CreateAsync(exhibitions.AsNoTracking(), pageNumber ?? 1, pageSize));
        }




        // GET: Exhibitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibition
                .FirstOrDefaultAsync(m => m.ExhibitionID == id);
            if (exhibition == null)
            {
                return NotFound();
            }

            return View(exhibition);
        }

        // GET: Exhibitions/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exhibitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("ExhibitionID,GalleryName,City,Zip,Country,StartingDate,FinishDate")] Exhibition exhibition)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(exhibition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exhibition);
        }

        // GET: Exhibitions/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibition.FindAsync(id);
            if (exhibition == null)
            {
                return NotFound();
            }
            return View(exhibition);
        }

        // POST: Exhibitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("ExhibitionID,GalleryName,City,Zip,Country,StartingDate,FinishDate")] Exhibition exhibition)
        {
            if (id != exhibition.ExhibitionID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(exhibition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExhibitionExists(exhibition.ExhibitionID))
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
            return View(exhibition);
        }

        // GET: Exhibitions/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibition
                .FirstOrDefaultAsync(m => m.ExhibitionID == id);
            if (exhibition == null)
            {
                return NotFound();
            }

            return View(exhibition);
        }

        // POST: Exhibitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exhibition = await _context.Exhibition.FindAsync(id);
            if (exhibition != null)
            {
                _context.Exhibition.Remove(exhibition);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExhibitionExists(int id)
        {
            return _context.Exhibition.Any(e => e.ExhibitionID == id);
        }
    }
}
