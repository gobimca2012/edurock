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

public partial class Modules_Login_Create : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkRegister_Click(object sender, EventArgs e)
    {
        AddData();
    }
    private void AddData()
    {


        string Username; if (true) { Username = txtUsername.Text; }

        string Password; if (true) { Password = txtPassword.Text; }

        int UserType; if (true) { UserType = Convert.ToInt32(RdbType.SelectedValue); }
       

        new LoginUserController().CreateUser(Username, Password, txtEmail.Text, UserType);
        
    }
}
