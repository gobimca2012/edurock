
using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Timers;
using System.Threading;
using System.IO;


using System.Net;


public class Task
{
    #region Static Variable
    static string CDirecotry = "/";
    
    #endregion
    #region Fields

    System.Timers.Timer timer = null;

    #endregion

    #region Properties

    public string Name { get; set; }

    public bool IsRunning { get; set; }

    public DateTime LastRunTime { get; set; }

    public bool IsLastRunSuccessful { get; set; }

    public double Interval { get; set; }

    public bool Stopped { get; set; }

    public string FilePath { get; set; }

    #endregion

    #region Public Constructors

    public Task(double interval)
    {
        this.Interval = interval;
        Initialize();
    }

    #endregion

    #region Public Methods

    public void Start()
    {
        this.Stopped = false;
        //this.StartTask();
    }

    public void Stop()
    {
        this.Stopped = true;
    }

    #endregion

    #region Private Methods

    private void Initialize()
    {
        this.Stopped = false;
        timer = new System.Timers.Timer(this.Interval);
        timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        timer.Enabled = true;
        timer.Start();
    }

    private void StartTask()
    {
        if (!this.Stopped)
        {
            if (!this.IsRunning)
            {
                this.IsRunning = true;
                 Thread thread = new Thread(new ThreadStart(Execute));
                thread.Start();
            }
        }
    }

    private void Execute()
    {
        try
        {
            this.LastRunTime = DateTime.Now;
            //new TripController().TripBookingConformSheduler();
            
            this.IsLastRunSuccessful = true;
            File.AppendAllText(this.FilePath, "End With Success\r\n");
            File.AppendAllText(this.FilePath, "================================\r\n");
        }
        catch
        {
            this.IsLastRunSuccessful = false;
            File.AppendAllText(this.FilePath, "End With Error\r\n");
            File.AppendAllText(this.FilePath, "================================\r\n");
        }
        finally
        {

            this.IsRunning = false;
        }
    }

    void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        if (!this.IsRunning)
        {
            
            File.AppendAllText(this.FilePath, DateTime.Now.ToString() + "\r\n");            
            StartTask();

        }
    }

    #endregion



}

