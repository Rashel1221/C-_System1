using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Models;
using System.Net.Http.Json;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public LibraryController()
        {
            _httpClient = new HttpClient();
        }

        [HttpPost("sync-student")]
        public async Task<IActionResult> SyncStudentToLibrary([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest(new { message = "Invalid student data." });
            }

            var libraryPayload = new
            {
                studentId = student.StudentId,
                fullName = student.Name,
                email = student.Email,
                mobile = student.Phone,
                password = "123456"
            };

            var libraryApiUrl = "http://localhost/Library-Management-System-master/library/api/index.php/students/sync";

            try
            {
                var response = await _httpClient.PostAsJsonAsync(libraryApiUrl, libraryPayload);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, new
                    {
                        message = "Failed to sync student to Library API.",
                        libraryResponse = result
                    });
                }

                return Ok(new
                {
                    message = "Student synced to Library API successfully.",
                    libraryResponse = result
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Error connecting to Library API.",
                    error = ex.Message
                });
            }
        }
    }
}