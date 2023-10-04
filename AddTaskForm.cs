using System;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class AddTaskForm : Form
    {
        private readonly DataGridView data;
        private readonly string today;
        private readonly Validation validation = new Validation();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AddTaskForm(DataGridView dataGridView, string today)
        {
            InitializeComponent();
            data = dataGridView;
            this.today = today;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxAllWeek_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAllWeek.Checked)
            {
                CheckBoxChecked();
            } 
            else
            {
                CheckBoxUnchecked();
            }
        }

        //Saves a new task
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int monday = checkBoxMonday.Checked ? 1 : 0;
            int tuesday = checkBoxTuesday.Checked ? 1 : 0;
            int wednesday = checkBoxWednesday.Checked ? 1 : 0;
            int thursday = checkBoxThursday.Checked ? 1 : 0;
            int friday = checkBoxFriday.Checked ? 1 : 0;
            int saturday = checkBoxSaturday.Checked ? 1 : 0;
            int sunday = checkBoxSunday.Checked ? 1 : 0;

            string validText = validation.ValidateTaskName(textBoxTaskName.Text);

            if (validText == "Passed")
            {
                LocalDatabase database = new LocalDatabase();
                database.WriteNewTask(textBoxTaskName.Text, monday, tuesday, wednesday, thursday, friday, saturday, sunday);

                UpdateDataGridView(database);

                CreateMessage(textBoxTaskName.Text + " added to list!");
                log.Info("Task Saved!");
                Close();
            }
            else
            {
                CreateMessage(validText);
                textBoxTaskName.Clear();
            }
            
        }

        private void UpdateDataGridView(LocalDatabase database)
        {
            data.DataSource = database.GetTasks(today);
            data.Update();
            data.Refresh();
        }

        //Checks all check boxes
        private void CheckBoxChecked()
        {
            checkBoxMonday.CheckState = CheckState.Checked;
            checkBoxTuesday.CheckState = CheckState.Checked;
            checkBoxWednesday.CheckState = CheckState.Checked;
            checkBoxThursday.CheckState = CheckState.Checked;
            checkBoxFriday.CheckState = CheckState.Checked;
            checkBoxSaturday.CheckState = CheckState.Checked;
            checkBoxSunday.CheckState = CheckState.Checked;
            groupBoxDays.Enabled = false;
        }

        //Unchecks all check boxes
        private void CheckBoxUnchecked()
        {
            checkBoxMonday.CheckState = CheckState.Unchecked;
            checkBoxTuesday.CheckState = CheckState.Unchecked;
            checkBoxWednesday.CheckState = CheckState.Unchecked;
            checkBoxThursday.CheckState = CheckState.Unchecked;
            checkBoxFriday.CheckState = CheckState.Unchecked;
            checkBoxSaturday.CheckState = CheckState.Unchecked;
            checkBoxSunday.CheckState = CheckState.Unchecked;
            groupBoxDays.Enabled = true;
        }

        //Creates a message box alerting the user if the task was added, or if there was a problem with the task name
        private void CreateMessage(String text)
        {
            MessageForm message = new MessageForm(text);
            message.Show();
        }
    }
}
