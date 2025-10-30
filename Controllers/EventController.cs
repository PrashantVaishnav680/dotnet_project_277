using Microsoft.AspNetCore.Mvc;
using EventRegSystem.Data;
using EventRegSystem.Models;

namespace EventRegSystem.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        // Show all registrations
        public IActionResult Index()
        {
            var registrations = _context.EventRegistrations.ToList();
            return View(registrations);
        }

        // GET: Create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Add registration
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventRegistration reg)
        {
            if (ModelState.IsValid)
            {
                _context.EventRegistrations.Add(reg);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(reg);
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            var reg = _context.EventRegistrations.Find(id);
            if (reg == null) return NotFound();
            return View(reg);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventRegistration reg)
        {
            if (ModelState.IsValid)
            {
                _context.EventRegistrations.Update(reg);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(reg);
        }

        // GET: Details
        public IActionResult Details(int id)
        {
            var reg = _context.EventRegistrations.Find(id);
            if (reg == null) return NotFound();
            return View(reg);
        }

        // GET: Delete
        public IActionResult Delete(int id)
        {
            var reg = _context.EventRegistrations.Find(id);
            if (reg == null) return NotFound();
            _context.EventRegistrations.Remove(reg);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
