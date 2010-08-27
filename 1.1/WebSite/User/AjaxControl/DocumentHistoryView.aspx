<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocumentHistoryView.aspx.cs"
    Inherits="User_AjaxControl_DocumentInfoView" %>

<%@ Register Src="../UserControl/UserToolTipLink1.1.ascx" TagName="UserToolTipLink"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray" id="header" runat="server">
            History</div>
        <asp:ListView ID="ListDocument" runat="server" DataKeyNames="DocumentID" OnItemDataBound="ListDocumentOnItemDataBound">
            <LayoutTemplate>
                <div class="whitecont">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="dasbo">
                    <div style="float: left; width: 550px">
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox">
                        &nbsp;&nbsp;<%#Eval("Name")%></aspajax:HyperLink>
                    </div>
                    <div>
                        Edit On
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate").ToString())) %>
                    </div>
                    <div>
                        <UNameLink:UNameLink ID="UNameLink1" runat="server" LoginUserID='<%#Eval("LoginUserID") %>' />
                    </div>
                    <div style="clear: both">
                    </div>
                    <div>
                        <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("DocumentID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
