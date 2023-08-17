using System;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message)
        {
            InitializeComponent();
            labelMessage.Text = message;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
