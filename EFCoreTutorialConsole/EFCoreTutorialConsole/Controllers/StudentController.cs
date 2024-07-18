
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using EFCoreTutorialConsole.Models.Requests;
using EFCoreTutorialConsole.Models.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace EFCoreTutorialConsole.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _context;
        private readonly IMapper _mapper;
        public StudentController(SchoolContext context,  IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        /*
                //get: /student
                [HttpGet]
                public async Task<ActionResult<BaseResponse<StudentDtoResponse>>> Getstudents()
                {
                    var studentResponse = await _context.Students.Include(s => s.Grade).ToListAsync();

                    List<StudentDtoResponse> students = new List<StudentDtoResponse>();

                    foreach (var student in studentResponse)
                    {
                        var studentData = new StudentDtoResponse
                        { Email = student.Email, FullName = student.Name, GradeName= student.Grade.GradeName, 
                        GradeDescription= student.Grade.GradeDescription};
                        students.Add(studentData);
                    }

                    var response = new BaseResponse<List<StudentDtoResponse>> { Status = (int)HttpStatusCode.OK, Message = "Successfull", Data = students };

                    return Ok(response);
                }
        */

        // Get using AutoMapping 
        [HttpGet]
        public async Task<ActionResult<BaseResponse<StudentDtoResponse>>> Getstudents()
        {
            var studentResponse = await _context.Students.Include(s => s.Grade).ToListAsync();

            // Use AutoMapper to map Student entities to StudentDtoResponse
            var students = _mapper.Map<List<StudentDtoResponse>>(studentResponse);

            var response = new BaseResponse<List<StudentDtoResponse>> { Status = (int)HttpStatusCode.OK, Message = "Successfull", Data = students };

            return Ok(response);
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Student>>> GetStudents(StudentRequest studentRequest)
        //{
        //    // Filter students based on the provided GradeId if it's provided
        //    IQueryable<Student> query = _context.Students;

        //    if (studentRequest.GradeId != 0)
        //    {
        //        query = query.Where(s => s.GradeId == studentRequest.GradeId);
        //    }

        //    var students = await query.Include(s => s.Grade).ToListAsync();
        //    return students;
        //}
        //get: /student?name={name}
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Student>>> GetStudentsByName(string enter_your_name)
        //{
        //    var students = await _context.Students
        //                                .Where(s => s.Name.Contains(enter_your_name))
        //                                //.Where(s => s.Id == studentId)
        //                                .ToListAsync();

        //    if (students == null || students.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return students;
        //}



        //GET: /Student/by id
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Student>> GetStudentById( int id)
        //{
        //    //var student = await _context.Students.FindAsync(id);
        //    var student = await _context.Students
        //                         .Include(s => s.Grade) // Include grade data
        //                         .FirstOrDefaultAsync(s => s.Id == id);


        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return student;
        //}


        // Get by id using AutoMapping
        [HttpGet("{id}")]
        public async Task<ActionResult<BaseResponse<StudentDtoResponse>>> GetStudentById(int id)
        {
            var student = await _context.Students.Include(s => s.Grade)
                                                  .FirstOrDefaultAsync(s => s.Id == id);

            if (student == null)
            {
                return NotFound(new BaseResponse<StudentDtoResponse> { Status = (int)HttpStatusCode.NotFound, Message = "Student not found", Data = null });
            }

            // Use AutoMapper to map Student entity to StudentDtoResponse
            var studentDto = _mapper.Map<StudentDtoResponse>(student);

            var response = new BaseResponse<StudentDtoResponse> { Status = (int)HttpStatusCode.OK, Message = "Successfull", Data = studentDto };

            return Ok(response);
        }


        //[httppost]
        //public async task<actionresult> createstudent(studentrequest student)
        //{
        //    var grade = await _context.grades.findasync(student.gradeid); // assuming grades is the dbset for grade
        //    if (grade == null)
        //    {
        //        return notfound("grade not found"); // return appropriate error message if the grade is not found
        //    }

        //    var student1 = new student { name = student.name, email = student.email, grade = grade };
        //    _context.students.add(student1);
        //    await _context.savechangesasync();
        //    return ok(new studentresponse { message = "user created sucessfully",status= "200" });

        //    //return createdataction(nameof(getstudentbyid), new { id = student1.id }, new studentresponse { message = "user created successfully", status = "201" });
        //}


        // Post using AutoMapper
        // POST method for creating a new student
        [HttpPost]
        public async Task<ActionResult<BaseResponse<StudentDtoResponse>>> CreateStudent(StudentDtoResponse studentDtoRequest)
        {
            try
            {
                // Map StudentDtoRequest to Student entity using AutoMapper
                var student = _mapper.Map<Student>(studentDtoRequest);

                // Add the new student to the database
                _context.Students.Add(student);
                await _context.SaveChangesAsync();

                // Map the created Student entity to StudentDtoResponse
                var createdStudentDto = _mapper.Map<StudentDtoResponse>(student);

                var response = new BaseResponse<StudentDtoResponse> { Status = (int)HttpStatusCode.Created, Message = "Student created successfully", Data = createdStudentDto };

                // Return the response with HTTP status code 201 (Created)
                return CreatedAtAction(nameof(GetStudentById), new { id = createdStudentDto.Id }, response);
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"An error occurred while creating a new student: {ex.Message}");

                // Return an error response with HTTP status code 500 (Internal Server Error)
                return StatusCode((int)HttpStatusCode.InternalServerError, new BaseResponse<StudentDtoResponse> { Status = (int)HttpStatusCode.InternalServerError, Message = "An error occurred while creating the student", Data = null });
            }
        }


        // Put using AutoMapping
        // PUT: /Student/
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // DELETE: /Student/
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStudent(int id)
        //{
        //    var student = await _context.Students.FindAsync(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Students.Remove(student);
        //    await _context.SaveChangesAsync();
        //    return Ok(new StudentResponse { Message = "user delete sucessfully", Status = "204" });

        //    return NoContent();
        //}


        // Delete using AutoMapper
        // DELETE: /Student/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<BaseResponse<object>>> DeleteStudent(int id)
        {
            try
            {
                // Retrieve the student from the database
                var student = await _context.Students.FindAsync(id);

                // If the student does not exist, return 404 Not Found
                if (student == null)
                {
                    return NotFound(new BaseResponse<object> { Status = (int)HttpStatusCode.NotFound, Message = "Student not found", Data = null });
                }

                // Remove the student from the database context
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();

                // Return success response with 204 No Content status code
                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"An error occurred while deleting the student: {ex.Message}");

                // Return an error response with HTTP status code 500 (Internal Server Error)
                return StatusCode((int)HttpStatusCode.InternalServerError, new BaseResponse<object> { Status = (int)HttpStatusCode.InternalServerError, Message = "An error occurred while deleting the student", Data = null });
            }
        }


        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}






