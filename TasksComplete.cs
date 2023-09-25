using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Daily_Tasks
{
    class TasksComplete
    {
        public TasksComplete()
        {

        }

        public void AllTasksComplete(int tasks, int tasksCompleted)
        {
            if (tasks == tasksCompleted)
            {
                AllTasksCompleted all = new AllTasksCompleted();
                all.Show();
            }
        }
    }
}
