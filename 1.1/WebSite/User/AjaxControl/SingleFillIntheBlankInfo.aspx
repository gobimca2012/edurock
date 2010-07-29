<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SingleFillIntheBlankInfo.aspx.cs"
    Inherits="User_AjaxControl_SingleFillIntheBlankInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Question</div>
        <div id="EXM_Question" class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <div>
                <div>
                    <div>
                        <span class="label">Question</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtQuestionPart1" runat="server" Width="579px"></asp:TextBox>
                        <span style="border-bottom: solid 1px">Fill in the Blank</span><br />
                        <asp:TextBox ID="txtQuestionPart2" runat="server" Width="579px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="329px"
                            Width="670px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Marks</span>
                    </div>
                    <div class="style1">
                        <asp:TextBox ID="txtMarks" runat="server" Width="62px"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <div class="gray">
            <div>
                <div>
                    <div style="float: left">
                        <%--<asp:LinkButton ID="lnkUpdate" runat="server" OnClick="lnkUpdate_Click">Update</asp:LinkButton>--%>
                        <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" OnAjaxClick="AjaxUpdateClick"
                            RequestContainner="#contentBox" ResponseContainner="#contentBox"><div class="btn">Update</div></aspajax:AjaxLinkButton>
                    </div>
                    <div>
                        <aspajax:AjaxLinkButton ID="lnkAddUserInfo" runat="server" OnAjaxClick="AjaxAddClick"
                            RequestContainner="#contentBox" ResponseContainner="#contentBox"><div class="btn">Save</div></aspajax:AjaxLinkButton>
                    </div>
                    <div style="float: left">
                        <aspajax:HyperLink ID="lnkCancel" runat="server" NavigateUrl="UserInfoView.aspx"
                            ContainnerID="#contentBox"><div class="btn">Cancel</div></aspajax:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
