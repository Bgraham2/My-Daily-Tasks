using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool writeNewTask(String taskName, int monday, int tuesday, int wednesday, int thursday, int friday, int saturday, int sunday)
        {
            string sql = "INSERT INTO TASKS VALUES(" + "'" + taskName + "'" + "," + monday + "," + tuesday + "," + wednesday + "," + thursday + "," + friday + "," + saturday + "," + sunday + ")";
            return dBInteraction(sql);
        }

        private bool dBInteraction(String sql)
        {
            
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataAdapter.InsertCommand = new SqlCommand(sql, sqlConnection);
            Int32 status = sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();

            if (status == 1)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
