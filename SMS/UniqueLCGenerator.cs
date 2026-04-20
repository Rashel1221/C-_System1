using System;
using System.Data;
using System.Data.SqlClient;

namespace SMS
{
    public static class UniqueLCGenerator
    {
        private static Random random = new Random();

        public static string GenerateUniqueLC()
        {
            string lcNo;
            bool isUnique = false;
            int attempts = 0;

            do
            {
                string year = DateTime.Now.Year.ToString();
                string randomNum = random.Next(1000, 9999).ToString();
                lcNo = $"LC-{year}-{randomNum}";
                isUnique = CheckUniqueness(lcNo);
                attempts++;

                if (attempts >= 100)
                {
                    lcNo = $"LC-{year}-{DateTime.Now.Ticks % 10000}";
                    break;
                }
            } while (!isUnique);

            return lcNo;
        }

        private static bool CheckUniqueness(string lcNo)
        {
            try
            {
                bool wasOpen = WControls.connection.State == ConnectionState.Open;
                if (!wasOpen) WControls.DBConOpen();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Student WHERE Library_Card=@LCNo",
                    WControls.connection);
                cmd.Parameters.AddWithValue("@LCNo", lcNo);
                int count = (int)cmd.ExecuteScalar();

                if (!wasOpen) WControls.DBConClose();
                return count == 0;
            }
            catch
            {
                return true;
            }
        }
    }
}