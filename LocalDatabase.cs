using System;
using System.Data;
using System.Data.SqlClient;

namespace My_Daily_Tasks
{
    class LocalDatabase
    {
        private static SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DailyTasksConnectionString);
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public LocalDatabase()
        {
            sqlConnection.Open();
        }

        public void writeNewTask(String taskName, int monday, int tuesday, int wednesday, int thursday, int friday, int saturday, int sunday)
        {
            string sql = "INSERT INTO TASKS VALUES(" + "'" + taskName + "'" + "," + monday + "," + tuesday + "," + wednesday + "," + thursday + "," + friday + "," + saturday + "," + sunday + ")";
            dBInteraction(sql);
        }

        public void deleteTask(String taskName)
        {
            string sql = "DELETE FROM TASKS WHERE TaskName='" + taskName + "'";
            dBInteraction(sql);
        }

        private void dBInteraction(String sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
        }

        public DataTable getTasks(String date)
        {
            DataTable tasks = new DataTable();

            string sql = "SELECT TaskName FROM TASKS WHERE " + date + " = 1";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(tasks);
            sqlDataAdapter.Dispose();
            sqlConnection.Close();

            return tasks;
        }
    }
}
