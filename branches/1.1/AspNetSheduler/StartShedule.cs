using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.ComponentModel;

namespace AspNetSheduler
{
    public enum SchedulerEnum
    {
        UserAvailability=1,
        JobInterest=2,
        PriorSheduler=3
    }
    public class StartShedule
    {
        public SchedulerEnum TaskToRun;
        public StartShedule(double Interval,SchedulerEnum TaskRun)
        {
            this.TaskToRun = TaskRun;
            System.Timers.Timer objTimer = new System.Timers.Timer(Interval);
            objTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            objTimer.Enabled = true;
            objTimer.Start();
        }
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Thread objNewThread = new Thread(new ThreadStart(Execute));
            objNewThread.IsBackground = true;
            objNewThread.Start();
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += new DoWorkEventHandler(DoWork);
            //worker.WorkerReportsProgress = false;
            //worker.WorkerSupportsCancellation = true;
            //worker.RunWorkerCompleted +=
            //       new RunWorkerCompletedEventHandler(WorkerCompleted);
            //// Calling the DoWork Method Asynchronously
            //worker.RunWorkerAsync();
        }
        private static void DoWork(object sender, DoWorkEventArgs e)
        {
            // Long running background operation           
          

        }
        private void Execute()
        {
            
        }
        private static void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // log when the worker is completed.

        }
 
    }
}
