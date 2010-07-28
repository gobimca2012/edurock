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

public partial class User_UserControl_FullViewSideInfo : System.Web.UI.UserControl
{
    public string SubjectName
    {
        get;
        set;

    }
    public string CourceName
    {
        get;
        set;

    }
    public int SubjectID
    {
        get;
        set;

    }
    public int CourceID
    {
        get;
        set;

    }
    public int LoginUserID
    {
        get;
        set;

    }
    public int EditorLoginUserID
    {
        get;
        set;
    }
    public DateTime ModifiedDate
    {
        get;
        set;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblCourceName.InnerText =new InstituteCourceController().GetInstituteCourceName(CourceID);
        lblSubjectName.InnerText =new InstituteSubjectController().GetInstituteSubjectName(SubjectID);
        UserToolTipLink1.LoginUserID = LoginUserID;
        UserToolTipLink1.EditorLoginUserID = EditorLoginUserID;
        UserToolTipLink1.ModifiedDate = ModifiedDate;

    }
}
