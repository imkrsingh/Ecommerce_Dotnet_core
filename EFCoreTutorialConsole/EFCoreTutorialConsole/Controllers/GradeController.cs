
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTutorialConsole.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorialConsole.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradeController : ControllerBase
    {
        private readonly SchoolContext _context;

        public GradeController(SchoolContext context)
        {
            _context = context;
        }

        // GET: /grade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grade>>> GetGrades()
        {
            return await _context.Grades.ToListAsync();
        }

        // GET: /grade/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Grade>> GetGradeById(int id)
        {
            var grade = await _context.Grades.FindAsync(id);

            if (grade == null)
            {
                return NotFound();
            }

            return grade;
        }

        // POST: /grade
        [HttpPost]
        public async Task<ActionResult<Grade>> CreateGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGradeById), new { id = grade.GradeId }, grade);
        }

        // PUT: /grade/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrade(int id, Grade grade)
        {
            if (id != grade.GradeId)
            {
                return BadRequest();
            }

            _context.Entry(grade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: /grade/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GradeExists(int id)
        {
            return _context.Grades.Any(e => e.GradeId == id);
        }
    }
}







