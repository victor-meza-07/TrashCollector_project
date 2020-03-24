using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomerModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CustomerModel.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerModel = await _context.CustomerModel
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.PrimaryKey == id);
            if (customerModel == null)
            {
                return NotFound();
            }

            return View(customerModel);
        }

        // GET: CustomerModels/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: CustomerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrimaryKey,FirstName,LatName,PickUpDate,ExtraPickUpDate,AmountOwed,StartOfCycle,EndOfCycle,IdentityUserId")] CustomerModel customerModel)
        {
            if (ModelState.IsValid)
            {
                var userID = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                customerModel.IdentityUserId = userID;
                _context.CustomerModel.Add(customerModel);

                _context.Add(customerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerModel.IdentityUserId);
            return View(customerModel);
        }

        // GET: CustomerModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerModel = await _context.CustomerModel.FindAsync(id);
            if (customerModel == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerModel.IdentityUserId);
            return View(customerModel);
        }

        // POST: CustomerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrimaryKey,FirstName,LatName,PickUpDate,ExtraPickUpDate,AmountOwed,StartOfCycle,EndOfCycle,IdentityUserId")] CustomerModel customerModel)
        {
            if (id != customerModel.PrimaryKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerModelExists(customerModel.PrimaryKey))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerModel.IdentityUserId);
            return View(customerModel);
        }

        // GET: CustomerModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerModel = await _context.CustomerModel
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.PrimaryKey == id);
            if (customerModel == null)
            {
                return NotFound();
            }

            return View(customerModel);
        }

        // POST: CustomerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerModel = await _context.CustomerModel.FindAsync(id);
            _context.CustomerModel.Remove(customerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerModelExists(int id)
        {
            return _context.CustomerModel.Any(e => e.PrimaryKey == id);
        }
    }
}
