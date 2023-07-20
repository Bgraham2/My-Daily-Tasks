using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class MainForm : Form
    {
        private DataTable tasks = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelToday.Text = DateTime.Today.DayOfWeek.ToString();
            getTasks();
        }

        private void getTasks()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DailyTasksConnectionString);
            sqlConnection.Open();
            string sql = "SELECT TaskName FROM TASKS WHERE " + labelToday.Text + " = 1";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(tasks);
            sqlDataAdapter.Dispose();
            sqlConnection.Close();

            this.dataGridViewTasks.DataSource = tasks;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            getTasks();
        }
    }
}
