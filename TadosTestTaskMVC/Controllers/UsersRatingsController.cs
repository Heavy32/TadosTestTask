using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TadosTestTask;
using TadosTestTask.Models.Contents;

namespace TadosTestTaskMVC.Controllers
{
    public class UsersRatingsController : Controller
    {
        private readonly ContentContext _context;

        public UsersRatingsController(ContentContext context)
        {
            _context = context;
        }

        // GET: UsersRatings
        public async Task<IActionResult> Index()
        {
            var contentContext = _context.UsersRatings.Include(u => u.Content).Include(u => u.User);
            return View(await contentContext.ToListAsync());
        }

        // GET: UsersRatings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersRating = await _context.UsersRatings
                .Include(u => u.Content)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (usersRating == null)
            {
                return NotFound();
            }

            return View(usersRating);
        }

        // GET: UsersRatings/Create
        public IActionResult Create()
        {
            ViewData["ContentId"] = new SelectList(_context.Contents, "Id", "Discriminator");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Login");
            return View();
        }

        // POST: UsersRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContentId,UserId,Rating")] UsersRating usersRating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersRating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContentId"] = new SelectList(_context.Contents, "Id", "Discriminator", usersRating.ContentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Login", usersRating.UserId);
            return View(usersRating);
        }

        // GET: UsersRatings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersRating = await _context.UsersRatings.FindAsync(id);
            if (usersRating == null)
            {
                return NotFound();
            }
            ViewData["ContentId"] = new SelectList(_context.Contents, "Id", "Discriminator", usersRating.ContentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Login", usersRating.UserId);
            return View(usersRating);
        }

        // POST: UsersRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContentId,UserId,Rating")] UsersRating usersRating)
        {
            if (id != usersRating.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersRating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersRatingExists(usersRating.UserId))
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
            ViewData["ContentId"] = new SelectList(_context.Contents, "Id", "Discriminator", usersRating.ContentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Login", usersRating.UserId);
            return View(usersRating);
        }

        // GET: UsersRatings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersRating = await _context.UsersRatings
                .Include(u => u.Content)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (usersRating == null)
            {
                return NotFound();
            }

            return View(usersRating);
        }

        // POST: UsersRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersRating = await _context.UsersRatings.FindAsync(id);
            _context.UsersRatings.Remove(usersRating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersRatingExists(int id)
        {
            return _context.UsersRatings.Any(e => e.UserId == id);
        }
    }
}
