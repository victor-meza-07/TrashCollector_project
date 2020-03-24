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
    public class EmployeeModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EmployeeModel.Include(e => e.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EmployeeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _context.EmployeeModel
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.PrimaryKey == id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return View(employeeModel);
        }

        // GET: EmployeeModels/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: EmployeeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrimaryKey,IdentityUserId,FirstName,LastName,Address,ZipCode")] EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                employeeModel.IdentityUserId = userId;
                _context.EmployeeModel.Add(employeeModel);

                _context.Add(employeeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employeeModel.IdentityUserId);
            return View(employeeModel);
        }

        // GET: EmployeeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _context.EmployeeModel.FindAsync(id);
            if (employeeModel == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employeeModel.IdentityUserId);
            return View(employeeModel);
        }

        // POST: EmployeeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrimaryKey,IdentityUserId,FirstName,LastName,Address,ZipCode")] EmployeeModel employeeModel)
        {
            if (id != employeeModel.PrimaryKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeModelExists(employeeModel.PrimaryKey))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employeeModel.IdentityUserId);
            return View(employeeModel);
        }

        // GET: EmployeeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeModel = await _context.EmployeeModel
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.PrimaryKey == id);
            if (employeeModel == null)
            {
                return NotFound();
            }

            return View(employeeModel);
        }

        // POST: EmployeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeModel = await _context.EmployeeModel.FindAsync(id);
            _context.EmployeeModel.Remove(employeeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeModelExists(int id)
        {
            return _context.EmployeeModel.Any(e => e.PrimaryKey == id);
        }


        /*MY LOGIC*/

        public IActionResult Default() 
        {
            //Get current User ID
            //Get Current User Zip
            //Get a list of all customers that fit that zip.

            List<CustomerModel> CustomersInZip = new List<CustomerModel>();
            
            var currentUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var currentEmployee = _context.EmployeeModel.Where(c => c.IdentityUserId == currentUserId).FirstOrDefault();
            if (currentEmployee != null)
            {
                var currentEmployeeZip = _context.EmployeeModel.Where(a => a.IdentityUserId == currentUserId).Select(a => a.ZipCode).FirstOrDefault();
                //Getemployees zip
                var listOfCustomers = _context.CustomerModel.Where(c => c.ZipCode == currentEmployeeZip);
                var todaysDate = DateTime.Today.ToString();
                var customersForTheDay = listOfCustomers.Where(c => c.PickUpDate == todaysDate);
                return View(customersForTheDay);
            }
            else 
            {
                return RedirectToAction("Index", "EmployeeModels");
            }
            
        }
    }
}
