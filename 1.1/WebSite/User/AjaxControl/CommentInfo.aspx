<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommentInfo.aspx.cs" Inherits="User_AjaxControl_CommentInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/div/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Comment</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Enter your Comment</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCommentText" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddComment" runat="server" RequestContainner="#newcommentbox"
                    ResponseContainner="#newcommentbox" OnAjaxClick="AddAjaxClick"><div class="btn" style="width:100px">Post Comment</div> </aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateComment" runat="server" RequestContainner="#newcommentbox"
                    ResponseContainner="#newcommentbox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
