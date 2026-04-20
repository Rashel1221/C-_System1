using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class BkIssue : UserControl
    {
        private List<string> selectedBooks = new List<string>();

        public BkIssue()
        {
            InitializeComponent();
            DatabaseSetup.EnsureBookIssueTableExists();
            SetupDataGridView();
        }

        private void BkIssue_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("BookName", "Book Name");
            dataGridView1.Columns.Add("IssueDate", "Issue Date");
            dataGridView1.Columns.Add("LibraryCardNo", "Library Card No.");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search_txb.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Input Required", "Please enter Student ID!");
                return;
            }

            try
            {
                WControls.DBConOpen();

                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT * FROM Student WHERE Student_id=@StudentId",
                    WControls.connection);
                adapter.SelectCommand.Parameters.AddWithValue("@StudentId", Search_txb.Text.Trim());

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Student_id_tbx.Text = table.Rows[0]["Student_id"].ToString();
                    StudentName_tbx.Text = table.Rows[0]["Name"].ToString();
                    Sec_tbx.Text = table.Rows[0]["Sec"].ToString();
                    Library_tbx.Text = table.Rows[0]["Library_Card"].ToString();

                    BookNames_tbx.Clear();
                    selectedBooks.Clear();

                    WControls.ShowToasterMsg("SUCCESS", "Student Found", "Student loaded successfully!");
                }
                else
                {
                    ClearFields();
                    WControls.ShowToasterMsg("WARNING", "Not Found", "Student not found!");
                }

                WControls.DBConClose();
            }
            catch (Exception ex)
            {
                WControls.ShowToasterMsg("ERROR", "Error", ex.Message);
                WControls.DBConClose();
            }
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Student_id_tbx.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Search student first!");
                return;
            }

            string bookName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Book Name:", "Add Book", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(bookName))
            {
                selectedBooks.Add(bookName.Trim());
                BookNames_tbx.Text = string.Join(Environment.NewLine, selectedBooks);
                WControls.ShowToasterMsg("SUCCESS", "Added", "Book added to list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Student_id_tbx.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Search student first!");
                return;
            }

            try
            {
                Library_tbx.Text = UniqueLCGenerator.GenerateUniqueLC();
                WControls.ShowToasterMsg("SUCCESS", "Generated", "Library Card Number generated!");
            }
            catch (Exception ex)
            {
                WControls.ShowToasterMsg("ERROR", "Error", ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Student_id_tbx.Text) ||
                string.IsNullOrWhiteSpace(Library_tbx.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Generate Library Card Number first!");
                return;
            }

            try
            {
                WControls.DBConClose();  // Close first if open
                WControls.DBConOpen();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Student SET Library_Card=@LCNo WHERE Student_id=@StudentId",
                    WControls.connection);
                cmd.Parameters.AddWithValue("@LCNo", Library_tbx.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentId", Student_id_tbx.Text.Trim());

                if (cmd.ExecuteNonQuery() > 0)
                    WControls.ShowToasterMsg("SUCCESS", "Updated", "Library Card Number updated!");
                else
                    WControls.ShowToasterMsg("ERROR", "Failed", "Update failed!");

                WControls.DBConClose();
            }
            catch (Exception ex)
            {
                WControls.ShowToasterMsg("ERROR", "Error", ex.Message);
                WControls.DBConClose();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Student_id_tbx.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Search student first!");
                return;
            }

            if (selectedBooks.Count == 0)
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Add at least one book!");
                return;
            }

            if (string.IsNullOrWhiteSpace(Library_tbx.Text))
            {
                WControls.ShowToasterMsg("WARNING", "Required", "Generate Library Card Number first!");
                return;
            }

            try
            {
                WControls.DBConOpen();
                int successCount = 0;

                foreach (string bookName in selectedBooks)
                {
                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO BookIssue (Student_id, Student_Name, Book_Name, Issue_Date, Library_Card_No, Section) 
                        VALUES (@StudentId, @StudentName, @BookName, @IssueDate, @LCNo, @Section)",
                         WControls.connection);

                    cmd.Parameters.AddWithValue("@StudentId", Student_id_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@StudentName", StudentName_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@BookName", bookName);
                    cmd.Parameters.AddWithValue("@IssueDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LCNo", Library_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@Section", Sec_tbx.Text.Trim());

                    if (cmd.ExecuteNonQuery() > 0) successCount++;
                }

                WControls.DBConClose();

                if (successCount == selectedBooks.Count)
                {
                    WControls.ShowToasterMsg("SUCCESS", "Issued", $"{successCount} book(s) issued successfully!");
                    ClearFields();
                    LoadIssuedBooks();
                }
                else
                {
                    WControls.ShowToasterMsg("WARNING", "Partial", $"Only {successCount} of {selectedBooks.Count} books issued!");
                }
            }
            catch (Exception ex)
            {
                WControls.ShowToasterMsg("ERROR", "Error", ex.Message);
                WControls.DBConClose();
            }
        }

        private void LoadIssuedBooks()
        {
            try
            {
                WControls.DBConOpen();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Student_id, Student_Name, Book_Name, Issue_Date, Library_Card_No FROM BookIssue WHERE Status='Issued' ORDER BY Issue_Date DESC",
                    WControls.connection);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.Rows.Clear();

                foreach (DataRow row in table.Rows)
                {
                    dataGridView1.Rows.Add(
                        row["Student_id"],
                        row["Student_Name"],
                        row["Book_Name"],
                        Convert.ToDateTime(row["Issue_Date"]).ToString("dd-MM-yyyy"),
                        row["Library_Card_No"]
                    );
                }

                WControls.DBConClose();
            }
            catch
            {
                WControls.DBConClose();
            }
        }

        private void ClearFields()
        {
            Search_txb.Clear();
            Student_id_tbx.Clear();
            StudentName_tbx.Clear();
            Sec_tbx.Clear();
            Library_tbx.Clear();
            BookNames_tbx.Clear();
            selectedBooks.Clear();
        }
    }
}