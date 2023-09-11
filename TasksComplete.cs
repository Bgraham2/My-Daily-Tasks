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

        public int AllTasksComplete(int tasks, int tasksCompleted)
        {
            if (tasks == tasksCompleted)
            {
                AllTasksCompleted all = new AllTasksCompleted();
                all.Show();
                return 1;
            } else
            {
                return -1;
            }
        }
    }
}
