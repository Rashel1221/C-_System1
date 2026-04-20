using System;
using System.Data.SqlClient;

namespace SMS
{
    public static class DatabaseSetup
    {
        private static bool tableChecked = false;

        public static void EnsureBookIssueTableExists()
        {
            if (tableChecked) return;

            string createTableSQL = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'BookIssue')
                BEGIN
                    CREATE TABLE BookIssue (
                        Issue_id INT PRIMARY KEY IDENTITY(1,1),
                        Student_id VARCHAR(50) NOT NULL,
                        Student_Name VARCHAR(100) NOT NULL,
                        Book_Name VARCHAR(200) NOT NULL,
                        Issue_Date DATETIME NOT NULL DEFAULT GETDATE(),
                        Return_Date DATETIME NULL,
                        Library_Card_No VARCHAR(50) NOT NULL,
                        Section VARCHAR(50) NULL,
                        Status VARCHAR(20) DEFAULT 'Issued',
                        Remarks VARCHAR(500) NULL,
                        Created_Date DATETIME DEFAULT GETDATE(),
                        Modified_Date DATETIME NULL
                    );

                    CREATE NONCLUSTERED INDEX IX_BookIssue_StudentId ON BookIssue(Student_id);
                    CREATE NONCLUSTERED INDEX IX_BookIssue_IssueDate ON BookIssue(Issue_Date DESC);
                    CREATE NONCLUSTERED INDEX IX_BookIssue_Status ON BookIssue(Status);
                    CREATE NONCLUSTERED INDEX IX_BookIssue_LibraryCardNo ON BookIssue(Library_Card_No);
                END";

            try
            {
                WControls.DBConOpen();
                SqlCommand cmd = new SqlCommand(createTableSQL, WControls.connection);
                cmd.ExecuteNonQuery();
                WControls.DBConClose();
                tableChecked = true;
            }
            catch
            {
                WControls.DBConClose();
            }
        }
    }
}