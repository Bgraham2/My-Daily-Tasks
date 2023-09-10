using System;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class AllTasksCompleted : Form
    {
        public AllTasksCompleted()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
