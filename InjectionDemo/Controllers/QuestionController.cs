using System.Linq;
using System.Threading.Tasks;
using InjectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InjectionDemo.Controllers
{
    public class QuestionController : Controller
    {
        private readonly InjectDatabaseContext _context;

        public QuestionController(InjectDatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var question = await _context.Questions.ToListAsync();
            return View(question.FirstOrDefault());
        }

        public async Task<IActionResult> SubmitQuestion([FromForm] Question question)
        {
            var savedQuestion = await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
            return View("Index", savedQuestion.Entity);
        }
    }
}