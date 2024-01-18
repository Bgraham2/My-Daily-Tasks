using System.Data;
using System.Data.SqlClient;

namespace My_Daily_Tasks
{
    class LocalDatabase
    {
        private static readonly SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DailyTasksConnectionString);
        private readonly SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LocalDatabase()
        {
            sqlConnection.Open();
            log.Info("Database connection sucessful.");
        }

        public void WriteNewTask(string taskName, int monday, int tuesday, int wednesday, int thursday, int friday, int saturday, int sunday)
        {
            string sql = "INSERT INTO TASKS VALUES(" + "'" + taskName + "'" + "," + monday + "," + tuesday + "," + wednesday + "," + thursday + "," + friday + "," + saturday + "," + sunday + ")";
            DBInteraction(sql);
            log.Info("New task added to database and connection closed.");
        }

        public void DeleteTask(string taskName)
        {
            string sql = "DELETE FROM TASKS WHERE TaskName='" + taskName + "'";
            DBInteraction(sql);
            log.Info("Task removed from the database and connection closed.");
        }

        private void DBInteraction(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
        }

        public DataTable GetTasks(string date)
        {
            DataTable tasks = new DataTable();

            string sql = "SELECT TaskName FROM TASKS WHERE " + date + " = 1";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlReadDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlReadDataAdapter.Fill(tasks);
            sqlReadDataAdapter.Dispose();
            sqlConnection.Close();
            log.Info("DataTable returned and connection closed.");

            return tasks;
        }
    }
}
