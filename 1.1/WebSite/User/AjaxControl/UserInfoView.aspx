<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfoView.aspx.cs" Inherits="User_AjaxControl_UserInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Users
        </div>
        <div id="User" class="whitecont">
            <div>
                <asp:Image ID="imgProfilepic" runat="server" Width="100" />
            </div>
            <div>
                <asp:LinkButton ID="lnkChangeImage" runat="server">UpdatePic</asp:LinkButton>
            </div>
            <div id="propop">
            </div>
            <div>
                <div>
                    <span class="label">FirstName</span>
                </div>
                <div>
                    <span id="lblFirstName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">LastName</span>
                </div>
                <div>
                    <span id="lblLastName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">MiddleName</span>
                </div>
                <div>
                    <span id="lblMiddleName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">BirthDate</span>
                </div>
                <div>
                    <span id="lblBirthDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Address1</span>
                </div>
                <div>
                    <span id="lblAddress1" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Address2</span>
                </div>
                <div>
                    <span id="lblAddress2" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">City</span>
                </div>
                <div>
                    <span id="lblCity" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">State</span>
                </div>
                <div>
                    <span id="lblState" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Country</span>
                </div>
                <div>
                    <span id="lblCountry" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">WebSite</span>
                </div>
                <div>
                    <span id="lblWebSite" runat="server"></span>
                </div>
            </div>
        </div>
        <div class="gray">
            <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox" NavigateUrl="UserInfo.aspx"><div class="btn"> Edit</div></aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
