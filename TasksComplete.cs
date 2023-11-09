
namespace My_Daily_Tasks
{
    class TasksComplete
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TasksComplete()
        {

        }

        //Takes in two int values, one is the number so tasks in the list.
        //The second is the number of tasks completed.
        //If they are equal, the all tasks complete form is shown and notifications are stopped
        public void AllTasksComplete(int tasks, int tasksCompleted, NotificationHelper notification)
        {
            if (tasks == tasksCompleted)
            {
                log.Info("All tasks complete.");
                notification.StopNotifications();
                AllTasksCompleted all = new AllTasksCompleted();
                all.Show();
            } else
            {
                log.Info("Task list is not complete.");
            }
        }
    }
}
