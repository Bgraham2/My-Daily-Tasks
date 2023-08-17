using System;
using System.Linq;

namespace My_Daily_Tasks
{
    class Validation
    {
       
        public Validation()
        {

        }

        public string ValidateTaskName(String task)
        {
            if (task.Length == 0)
            {
                return "Task name field can't be empty!";
            }
            else if (task.Any(ch => ! char.IsLetterOrDigit(ch)))
            {
                return "Task name can't contain special characters!";
            }
            else
            {
                return "Passed";
            }
        }
    }
}
