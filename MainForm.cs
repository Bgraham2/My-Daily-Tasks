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
        private String today = DateTime.Today.DayOfWeek.ToString();

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
            labelToday.Text = today;
            this.dataGridViewTasks.DataSource = returnTasks(today);
            getTasks();
        }

        private void getTasks()
        {

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

            this.dataGridViewTasks.DataSource = returnTasks(today);
            dataGridViewTasks.Update();
            dataGridViewTasks.Refresh();
        }

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 & e.RowIndex >= 0)
            {
                dataGridViewTasks.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Green;
            }

            if (e.ColumnIndex == 2 & e.RowIndex >= 0)
            {
                LocalDatabase database = new LocalDatabase();
                database.deleteTask(dataGridViewTasks.Rows[e.RowIndex].Cells["TaskName"].Value.ToString());
            }
        }

        private DataTable returnTasks(String date)
        {
            LocalDatabase database = new LocalDatabase();
            return database.getTasks(date);
        }
    }
}
