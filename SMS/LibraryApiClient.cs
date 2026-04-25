using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class LibraryApiClient
    {
        private readonly HttpClient client = new HttpClient();

        private string baseUrl = "http://localhost/Library-Management-System-master/library/api/index.php";

        public async Task<string> SyncStudent(string id, string name, string email, string mobile)
        {
            var json = $@"{{
                ""studentId"": ""{id}"",
                ""fullName"": ""{name}"",
                ""email"": ""{email}"",
                ""mobile"": ""{mobile}"",
                ""password"": ""123456""
            }}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(baseUrl + "/students/sync", content);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> IssueBook(int bookId, string studentId)
        {
            var json = $@"{{
                ""bookId"": {bookId},
                ""studentId"": ""{studentId}""
            }}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(baseUrl + "/issues", content);

            return await response.Content.ReadAsStringAsync();
        }
    }
}