using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLogic;

public partial class College_TutorialInfo : BasePage
{

    private void AddData()
    {
        try
        {



            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string Name; if (false) { throw new Exception(""); } Name = txtName.Text;

            string Description; if (false) { throw new Exception(""); } Description = txtDescription.Text;

            int TutorialType = Convert.ToInt32(ddTutorialType.SelectedValue);

            string FilePath; if (false) { throw new Exception(""); } FilePath = new TutorialController().UploadTutorial(FileUploader);

            DateTime ModifiedDate = DateTime.Now;

            new TutorialController().Add(LoginUserID, TutorialType, Name, Description, FilePath, ModifiedDate);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {


        int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

        string Name; if (false) { throw new Exception(""); } Name = txtName.Text;

        string Description; if (false) { throw new Exception(""); } Description = txtDescription.Text;

        int TutorialType; if (false) { throw new Exception(""); } TutorialType = Convert.ToInt32(ddTutorialType.SelectedValue);

        string FilePath; if (false) { throw new Exception(""); } FilePath = new TutorialController().UploadTutorial(FileUploader);

        DateTime ModifiedDate = DateTime.Now;

        new TutorialController().UpdateByTutorialID(TutorialID, TutorialType, LoginUserID, Name, Description, FilePath, ModifiedDate);
    }

    private void BindData(Guid ID)
    {
        var dataBunch = new TutorialController().GetbyTutorialID(TutorialID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            txtName.Text = data.Name;

            txtDescription.Text = data.Description;
            new TutorialTypeController().BindTutorialType(ddTutorialType, data.TutorialType.ToString());
            


        }
    }

    private int TutorialID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["tid"]);


        }



    }
    private bool IsEdit
    {
        get
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["id"] != null)
                {

                    //			ID = new Guid(Request.QueryString["id"]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        if (!this.IsPostBack)
        {
            new TutorialTypeController().BindTutorialType(ddTutorialType);
        }
        base.OnLoad(e);
    }

    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        AddData();
        string sc = string.Format("<script type='text/javascript'>$('#tutpop').dialog('close');</script>");
        injectScript.Text = sc;
    }

}
