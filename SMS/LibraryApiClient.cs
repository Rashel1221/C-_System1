using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class LibraryApiClient
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string baseUrl;

        public LibraryApiClient()
        {
            baseUrl = ConfigurationManager.AppSettings["LibraryApiBaseUrl"];
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                baseUrl = "http://localhost/Library-Management-System-master/library/api/index.php";
            }
            baseUrl = baseUrl.TrimEnd('/');
        }

        public async Task<string> SyncStudent(string id, string name, string email, string mobile)
        {
            string json = "{" +
                "\"studentId\":\"" + JsonEscape(id) + "\"," +
                "\"fullName\":\"" + JsonEscape(name) + "\"," +
                "\"email\":\"" + JsonEscape(email) + "\"," +
                "\"mobile\":\"" + JsonEscape(mobile) + "\"," +
                "\"password\":\"123456\"" +
                "}";
            return await PostJson("/students/sync", json);
        }

        public async Task<string> IssueBook(int bookId, string studentId)
        {
            string json = "{\"bookId\":" + bookId.ToString(CultureInfo.InvariantCulture) + ",\"studentId\":\"" + JsonEscape(studentId) + "\"}";
            return await PostJson("/issues", json);
        }
        public async Task<string> IssueBookByName(string bookName, string studentId)
        {
            string json = "{\"bookName\":\"" + JsonEscape(bookName) + "\",\"studentId\":\"" + JsonEscape(studentId) + "\"}";
            return await PostJson("/issues/by-book-name", json);
        }

        public async Task<string> ReturnBook(int bookId, string studentId, decimal fine)
        {
            string json = "{\"bookId\":" + bookId.ToString(CultureInfo.InvariantCulture) + ",\"studentId\":\"" + JsonEscape(studentId) + "\",\"fine\":" + fine.ToString(CultureInfo.InvariantCulture) + "}";
            return await PostJson("/returns", json);
        }

        public async Task<string> ReturnBookByName(string bookName, string studentId, decimal fine)
        {
            string json = "{\"bookName\":\"" + JsonEscape(bookName) + "\",\"studentId\":\"" + JsonEscape(studentId) + "\",\"fine\":" + fine.ToString(CultureInfo.InvariantCulture) + "}";
            return await PostJson("/returns/by-book-name", json);
        }

        public async Task<string> GetBooks()
        {
            HttpResponseMessage response = await client.GetAsync(baseUrl + "/books");
            string body = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode) throw new ApplicationException("Library API error: " + body);
            return body;
        }

        public async Task<List<IssuedBookDto>> GetIssuedBooks()
        {
            string url = baseUrl + "/issued-books";
            string json = await client.GetStringAsync(url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<IssuedBookDto>>(json);
        }

        public class IssuedBookDto
        {
            public int id { get; set; }
            public int BookId { get; set; }
            public string StudentID { get; set; }
            public string IssuesDate { get; set; }
            public int? RetrunStatus { get; set; }
            public string student_name { get; set; }
            public string book_name { get; set; }
            public string isbn { get; set; }
        }

        private async Task<string> PostJson(string route, string json)
        {
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage response = await client.PostAsync(baseUrl + route, content);
                string body = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode) throw new ApplicationException("Library API error: " + body);
                return body;
            }
        }

        private static string JsonEscape(string value)
        {
            if (value == null) return string.Empty;
            return value.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n");
        }
    }
}
