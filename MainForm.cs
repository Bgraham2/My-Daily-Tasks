using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.Show();
        }
    }
}
