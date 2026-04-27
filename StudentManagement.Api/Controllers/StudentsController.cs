using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
            private static readonly List<Student> Students = new();

            [HttpGet]
            public IActionResult GetAllStudents()
            {
                return Ok(Students);
            }

            [HttpGet("{id}")]
            public IActionResult GetStudentById(int id)
            {
                var student = Students.FirstOrDefault(s => s.Id == id);

                if (student == null)
                {
                    return NotFound(new { message = "Student not found." });
                }

                return Ok(student);
            }

            [HttpPost]
            public IActionResult CreateStudent([FromBody] Student student)
            {
                if (student == null)
                {
                    return BadRequest(new { message = "Invalid student data." });
                }

                if (student.Id == 0)
                {
                    student.Id = Students.Count + 1;
                }

                Students.Add(student);

                return Ok(new
                {
                    message = "Student created successfully.",
                    data = student
                });
            }

            [HttpPut("{id}")]
            public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
            {
                var student = Students.FirstOrDefault(s => s.Id == id);

                if (student == null)
                {
                    return NotFound(new { message = "Student not found." });
                }

                student.StudentId = updatedStudent.StudentId;
                student.Name = updatedStudent.Name;
                student.Email = updatedStudent.Email;
                student.Phone = updatedStudent.Phone;
                student.LibraryCard = updatedStudent.LibraryCard;

                return Ok(new
                {
                    message = "Student updated successfully.",
                    data = student
                });
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteStudent(int id)
            {
                var student = Students.FirstOrDefault(s => s.Id == id);

                if (student == null)
                {
                    return NotFound(new { message = "Student not found." });
                }

                Students.Remove(student);

                return Ok(new { message = "Student deleted successfully." });
            }
        }
    }
