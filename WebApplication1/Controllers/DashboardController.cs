using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userNotes = await _context.UserNotes.Where(n => n.UserId == userId).ToListAsync();

            return View(userNotes);
        }
        [HttpPost]
        public async Task<IActionResult> AddNote(string title, string content)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content)) return RedirectToAction("Index");

            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var note = new UserNote
            {
                UserId = userId,
                Title = title,
                Content = content
            };

            _context.UserNotes.Add(note);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
