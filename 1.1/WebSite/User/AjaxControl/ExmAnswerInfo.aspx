<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExmAnswerInfo.aspx.cs" Inherits="User_AjaxControl_ExmAnswerInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/div/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Answer
        </div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>EXM_Answer</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Answer</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Is Right</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkIsRight" runat="server" />
                    </div>
                </div>
               
            </div>
        </fieldset>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddEXM_Answer" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateEXM_Answer" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
