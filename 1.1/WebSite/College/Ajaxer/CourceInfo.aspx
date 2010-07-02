<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceInfo.aspx.cs" Inherits="College_Ajaxer_InstituteCourceInfo" %>

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
            <legend>Cource</legend>
            <div>
                <div>
                    <div>
                        <span class="label">CourceID</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CourceCatagoryID</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCourceCatagory" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CourceName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtCourceName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">CourceType</span>
                    </div>
                    <div>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Modifieddate</span>
                    </div>
                    <div>
                    </div>
                </div>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddCource" runat="server" RequestContainner="#addcource" 
                    ResponseContainner="#addcource" OnAjaxClick="AddCourceAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
