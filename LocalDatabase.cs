using System;
using System.Data;
using System.Data.SqlClient;

namespace My_Daily_Tasks
{
    class LocalDatabase
    {
        private static readonly SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DailyTasksConnectionString);
        private readonly SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public LocalDatabase()
        {
            sqlConnection.Open();
        }

        public int WriteNewTask(String taskName, int monday, int tuesday, int wednesday, int thursday, int friday, int saturday, int sunday)
        {
            string sql = "INSERT INTO TASKS VALUES(" + "'" + taskName + "'" + "," + monday + "," + tuesday + "," + wednesday + "," + thursday + "," + friday + "," + saturday + "," + sunday + ")";
            return DBInteraction(sql);
        }

        public int DeleteTask(String taskName)
        {
            string sql = "DELETE FROM TASKS WHERE TaskName='" + taskName + "'";
            return DBInteraction(sql);
            
        }

        private int DBInteraction(String sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand = new SqlCommand(sql, sqlConnection);
            int success = sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
            return success;
        }

        public DataTable GetTasks(String date)
        {
            DataTable tasks = new DataTable();

            string sql = "SELECT TaskName FROM TASKS WHERE " + date + " = 1";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlReadDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlReadDataAdapter.Fill(tasks);
            sqlReadDataAdapter.Dispose();
            sqlConnection.Close();

            return tasks;
        }
    }
}
