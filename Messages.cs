using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Daily_Tasks
{
    class Messages
    {
        private String message;
        private String title;
        private MessageBoxButtons buttons = MessageBoxButtons.OK;
        public Messages(String message, String title)
        {
            this.message = message;
            this.title = title;
        }

        public void displayMessage()
        {
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);

        }
    }
}
