using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class MainForm : Form
    {
        private readonly string today = DateTime.Today.DayOfWeek.ToString();
        private int taskCompleted = 0;
        private readonly Timer notificationTimer = new Timer();
        private readonly TasksComplete complete = new TasksComplete();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainForm()
        {
            InitializeComponent();
        }

        //Load form and create DataGridView.
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelToday.Text = today;
            dataGridViewTasks.DataSource = ReturnTasks(today);
            CreateDataGridView();
            StartNotifications();
            log.Info("DataGridView created.");
        }

        //Shows add task form when button clicked.
        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            log.Info("Add new task clicked.");
            AddTaskForm addTaskForm = new AddTaskForm(dataGridViewTasks, today);
            addTaskForm.Show();
            taskCompleted = addTaskForm.ReturnCounter;
        }

        //Buttom click reset task list and set counter to 0.
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            dataGridViewTasks.DataSource = ReturnTasks(today);
            dataGridViewTasks.Update();
            dataGridViewTasks.Refresh();
            taskCompleted = 0;
            notificationTimer.Start();
            log.Info("Task list complete track cleared.");
            
        }
        
        //Handles button clicks in the DataGridView
        //The first option is the complete button click, it marks the task as complete and increments the comlete tracker integer
        //The second option deletes the task from the list
        private void DataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridViewTasks.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Green;
                taskCompleted++;
                complete.AllTasksComplete(dataGridViewTasks.Rows.Count, taskCompleted, notificationTimer);
                log.Info("Task marked as complete, task counter set to: " + taskCompleted);
            }

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                LocalDatabase database = new LocalDatabase();
                database.DeleteTask(dataGridViewTasks.Rows[e.RowIndex].Cells["TaskName"].Value.ToString());
                dataGridViewTasks.DataSource = ReturnTasks(today);
                dataGridViewTasks.Update();
                dataGridViewTasks.Refresh();
                log.Info("Task Deleted.");
            }
        }

        //Fills datagridview.
        private DataTable ReturnTasks(string date)
        {
            LocalDatabase database = new LocalDatabase();
            log.Info("DataTable returned.");
            return database.GetTasks(date);
        }

        //sets datagridview properties
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

        private void StartNotifications()
        {
            notificationTimer.Tick += new EventHandler(Notification);
            notificationTimer.Interval = 3600000 / 2;
            notificationTimer.Enabled = true;
            log.Info("Notifications started.");
        }

        private void Notification(object source, EventArgs e)
        {
            Notifications n = new Notifications();
            n.Show();
        }
    }
}
