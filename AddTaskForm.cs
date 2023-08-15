using System;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class AddTaskForm : Form
    {
        private readonly DataGridView data;
        private readonly string today;
        private readonly Validation validation = new Validation();

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

                Close();
            }
            else
            {

            }
            
        }

        private void UpdateDataGridView(LocalDatabase database)
        {
            data.DataSource = database.GetTasks(today);
            data.Update();
            data.Refresh();
        }

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
    }
}
