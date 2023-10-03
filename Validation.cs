using System;
using System.Linq;

namespace My_Daily_Tasks
{
    class Validation
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Validation()
        {

        }

        //String value of the task name typed in the form.
        //The value is checked to make sure is not null, or it contains special characters.
        //The method returns a message if test fails, or returns "passed" is test passes.
        public string ValidateTaskName(String task)
        {
            if (task.Length == 0)
            {
                log.Error("Task name failed validation because task name is blank.");
                return "Task name field can't be empty!";
            }
            else if (task.Any(ch => ! char.IsLetterOrDigit(ch)))
            {
                log.Error("Task name failed validation becaused task name contains special characters.");
                return "Task name can't contain special characters!";
            }
            else
            {
                log.Info("Task name is valid.");
                return "Passed";
            }
        }
    }
}
