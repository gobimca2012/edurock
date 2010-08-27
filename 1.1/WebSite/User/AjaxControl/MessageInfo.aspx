<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageInfo.aspx.cs" Inherits="User_AjaxControl_MessageInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Compose Message</div>
        <div class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend>Message</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Subject</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtSubject" runat="server" Width="366px"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">MessageText</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtMessageText" runat="server" Height="274px" TextMode="MultiLine"
                                Width="369px"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">To User</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtUsername" runat="server" Width="365px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddMessage" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><%=Resources.Default.Add_Text%></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateMessage" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
