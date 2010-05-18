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
using System.IO;
/// <summary> /// Summary description for TaskScheduler /// </summary>
public class TaskScheduler
{
    #region Fields


    Task task = null;


    #endregion


    #region Public Constructors


    public TaskScheduler()
    {
        Initialize();
    }


    #endregion


    #region Public Methods


    public void StartTask()
    {
        this.task.Start();
    }


    public void StopTask()
    {
        this.task.Stop();
    }


    #endregion


    #region Public Constructors


    private void Initialize()
    {
        //this.task = new Task(3600000);        
        this.task = new Task(2000);        
        this.task.FilePath = @"C:\file.txt";
    }


    #endregion
}

