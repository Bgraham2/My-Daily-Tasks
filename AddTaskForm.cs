﻿using System;
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
    public partial class AddTaskForm : Form
    {

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxAllWeek_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAllWeek.Checked)
            {
                checkBoxChecked();
            } 
            else
            {
                checkBoxUnchecked();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int monday = checkBoxMonday.Checked ? 1 : 0;
            int tuesday = checkBoxTuesday.Checked ? 1 : 0;
            int wednesday = checkBoxWednesday.Checked ? 1 : 0;
            int thursday = checkBoxThursday.Checked ? 1 : 0;
            int friday = checkBoxFriday.Checked ? 1 : 0;
            int saturday = checkBoxSaturday.Checked ? 1 : 0;
            int sunday = checkBoxSunday.Checked ? 1 : 0;

            LocalDatabase database = new LocalDatabase();
            database.writeNewTask(textBoxTaskName.Text, monday, tuesday, wednesday, thursday, friday, saturday, sunday);

            this.Close();
        }

        private void checkBoxChecked()
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

        private void checkBoxUnchecked()
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
