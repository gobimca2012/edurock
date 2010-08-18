<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfo.aspx.cs"
    Inherits="College_Ajaxer_CourceCatagoryInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
        </div>
        <div style="padding: 5px;">
            <div id="divMessage" runat="server">
            </div>
            <div class="whitecont">
                <fieldset>
                    <legend>CourceCatagory</legend>
                    <div>
                        <div>
                            <div>
                                <span class="label">Catagory Name</span><span class="valmsg" >(Required)*</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtCatagoryName" runat="server" Width="385px"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Description</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtDescription" runat="server" Height="143px" TextMode="MultiLine"
                                    Width="387px"></asp:TextBox>
                            </div>
                        </div>
                       
                    </div>
                </fieldset>
            </div>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddcource" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn">Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
