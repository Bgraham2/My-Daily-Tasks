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

            DataGridViewColumn taskColumn = dataGridViewTasks.Columns[0];
            taskColumn.Width = 335;

            DataGridViewButtonColumn completeButtonColumn = new DataGridViewButtonColumn();
            completeButtonColumn.Width = 125;
            completeButtonColumn.HeaderText = "Complete";
            completeButtonColumn.Text = "Complete";
            completeButtonColumn.UseColumnTextForButtonValue = true;
            completeButtonColumn.FlatStyle = FlatStyle.Flat;
            completeButtonColumn.DefaultCellStyle.BackColor = Color.Green;
            completeButtonColumn.DefaultCellStyle.SelectionBackColor = Color.Green;

            if (dataGridViewTasks.Columns["Complete"] == null)
            {
                dataGridViewTasks.Columns.Add(completeButtonColumn);
            }

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Width = 90;
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.FlatStyle = FlatStyle.Flat;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            deleteButtonColumn.DefaultCellStyle.SelectionBackColor = Color.Red;

            if (dataGridViewTasks.Columns["Delete"] == null)
            {
                dataGridViewTasks.Columns.Add(deleteButtonColumn);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            tasks.Clear();
            getTasks();
        }

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 & e.RowIndex >= 0)
            {
                dataGridViewTasks.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Green;
            }

            if (e.ColumnIndex == 2 & e.RowIndex >= 0)
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DailyTasksConnectionString);
                sqlConnection.Open();
                string sql = "DELETE FROM TASKS WHERE TaskName=" +"'" + dataGridViewTasks.Rows[e.RowIndex].Cells["TaskName"].Value.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.InsertCommand = new SqlCommand(sql, sqlConnection);
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
        }
    }
}
