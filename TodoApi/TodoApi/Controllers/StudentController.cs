using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;
        private readonly long Id;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        // GET: api/StudentItems1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetTodoItems()
        {
            return await _context.StudentItem.ToListAsync();
        }

        // GET: api/StudentItems1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetTodoItem(long id)
        {
            var studentItem = await _context.StudentItem.FindAsync(id);


            if (studentItem == null)
            {
                return NotFound();
            }

            return studentItem;
        }

        //PUT: api/StudentItems1/5
                // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Student studentItem)
        {
            if (id != studentItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
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

        // POST: api/StudentItems1
        [HttpPost]
        public async Task<ActionResult<Student>> PostTodoItem(Student student)
        {
            _context.StudentItem.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = student.Id }, student);
        }

        // DELETE: api/StudentItems1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var studentItem = await _context.StudentItem.FindAsync(id);
            if (studentItem == null)
            {
                return NotFound();
            }

            _context.StudentItem.Remove(studentItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        private bool TodoItemExists(long id)
        {
            throw new NotImplementedException();
        }
    }
}
