using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class MainForm : Form
    {
        private readonly String today = DateTime.Today.DayOfWeek.ToString();
        private int taskCompleted = 0;
        private TasksComplete complete = new TasksComplete();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelToday.Text = today;
            dataGridViewTasks.DataSource = ReturnTasks(today);
            CreateDataGridView();
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(dataGridViewTasks, today);
            addTaskForm.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            dataGridViewTasks.DataSource = ReturnTasks(today);
            dataGridViewTasks.Update();
            dataGridViewTasks.Refresh();
            taskCompleted = 0;
        }

        private void DataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridViewTasks.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Green;
                taskCompleted++;
                complete.AllTasksComplete(dataGridViewTasks.Rows.Count, taskCompleted);
            }

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                LocalDatabase database = new LocalDatabase();
                database.DeleteTask(dataGridViewTasks.Rows[e.RowIndex].Cells["TaskName"].Value.ToString());
                dataGridViewTasks.DataSource = ReturnTasks(today);
                dataGridViewTasks.Update();
                dataGridViewTasks.Refresh();
            }
        }

        private DataTable ReturnTasks(String date)
        {
            LocalDatabase database = new LocalDatabase();
            return database.GetTasks(date);
        }

        private void CreateDataGridView()
        {
            DataGridViewColumn taskColumn = dataGridViewTasks.Columns[0];
            taskColumn.Width = 335;

            DataGridViewButtonColumn completeButtonColumn = new DataGridViewButtonColumn
            {
                Width = 125,
                HeaderText = "Complete",
                Text = "Complete",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };
            completeButtonColumn.DefaultCellStyle.BackColor = Color.Green;
            completeButtonColumn.DefaultCellStyle.SelectionBackColor = Color.Green;

            if (dataGridViewTasks.Columns["Complete"] == null)
            {
                dataGridViewTasks.Columns.Add(completeButtonColumn);
            }

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Width = 90,
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            deleteButtonColumn.DefaultCellStyle.SelectionBackColor = Color.Red;

            if (dataGridViewTasks.Columns["Delete"] == null)
            {
                dataGridViewTasks.Columns.Add(deleteButtonColumn);
            }
        }
    }
}
