<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnswerInfo.aspx.cs" Inherits="User_AjaxControl_AnswerInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
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
            <legend>Answer</legend>
            <div>
                
                <div>
                    <div>
                        <span class="label">AnswerText</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtAnswerText" runat="server" Width="346px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDescription" runat="server" Height="191px" 
                            TextMode="MultiLine" Width="350px"></asp:TextBox>
                    </div>
                </div>
               
               
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddAnswer" runat="server" RequestContainner="#Answer"
                    ResponseContainner="#Answer" OnAjaxClick="AddAjaxClick"><%=Resources.Default.Add_Text%></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateAnswer" runat="server" RequestContainner="#Answer"
                    ResponseContainner="#Answer" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
