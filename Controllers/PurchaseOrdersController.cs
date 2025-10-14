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
    public class PurchaseOrdersController : Controller
    {
        private readonly Context _context;

        public PurchaseOrdersController(Context context)
        {
            _context = context;
        }

        // GET: PurchaseOrders
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["OrderCostSortParm"] = sortOrder == "ordercost" ? "ordercost_desc" : "ordercost";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var purchaseorders = _context.PurchaseOrder
                .Include(p => p.Art) 
                .Include(p => p.Customer)  
                .AsQueryable();

            // Applies search filter
            if (!string.IsNullOrEmpty(searchString))
            {
    
                if (int.TryParse(searchString, out int parsedCost))
                {
                    purchaseorders = purchaseorders.Where(p => p.OrderCost == parsedCost);
                }
                else
                {
                   
                    purchaseorders = purchaseorders.Where(p => false); // This will return no results if search is wrong
                }
            }

            // Applies sorting based on OrderCost
            switch (sortOrder)
            {
                case "ordercost_desc":
                    purchaseorders = purchaseorders.OrderByDescending(p => p.OrderCost);
                    break;
                default:
                    purchaseorders = purchaseorders.OrderBy(p => p.OrderCost);
                    break;
            }

            // Pagination
            int pageSize = 5;
            return View(await PaginatedList<PurchaseOrder>.CreateAsync(purchaseorders.AsNoTracking(), pageNumber ?? 1, pageSize));
        }



        // GET: PurchaseOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Art)
                .Include(p => p.Customer)
                .FirstOrDefaultAsync(m => m.PurchaseOrderID == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["ArtID"] = new SelectList(_context.Art, "ArtId", "ArtId");
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerID");
            return View();
        }

        // POST: PurchaseOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("PurchaseOrderID,ArtID,CustomerID,OrderCost,OrderDate,StartingDate,FinishDate")] PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.StartingDate >= purchaseOrder.FinishDate)
            {
                ModelState.AddModelError("FinishDate", "Finish must be after starting date");
            }
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtID"] = new SelectList(_context.Art, "ArtId", "ArtId", purchaseOrder.ArtID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerID", purchaseOrder.CustomerID);
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            ViewData["ArtID"] = new SelectList(_context.Art, "ArtId", "ArtId", purchaseOrder.ArtID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerID", purchaseOrder.CustomerID);
            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseOrderID,ArtID,CustomerID,OrderCost,OrderDate,StartingDate,FinishDate")] PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.PurchaseOrderID)
            {
                return NotFound();
            }

            if (purchaseOrder.StartingDate >= purchaseOrder.FinishDate)
            {
                ModelState.AddModelError("FinishDate", "Finish must be after starting date");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderExists(purchaseOrder.PurchaseOrderID))
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
            ViewData["ArtID"] = new SelectList(_context.Art, "ArtId", "ArtId", purchaseOrder.ArtID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerID", purchaseOrder.CustomerID);
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.Art)
                .Include(p => p.Customer)
                .FirstOrDefaultAsync(m => m.PurchaseOrderID == id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(id);
            if (purchaseOrder != null)
            {
                _context.PurchaseOrder.Remove(purchaseOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.PurchaseOrderID == id);
        }
    }
}
