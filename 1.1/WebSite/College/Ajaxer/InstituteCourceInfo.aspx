<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfo" %>

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
            <legend>InstituteCource</legend>
            <div>
                <div>
                    <div>
                        <span class="label">CourceID</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCourceID" runat="server">
                        </asp:DropDownList>
                        <span>
                            <aspajax:ShowHideLinkButton ID="lnkCource" runat="server" ContainnerID="#addcource"
                                Show="true" PostBackUrl="~/College/Ajaxer/CourceInfo.aspx">Add New Cource</aspajax:ShowHideLinkButton></span>
                    </div>
                    <div id="addcource" style="display: none">
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
                <aspajax:AjaxLinkButton ID="lnkAddIcource" runat="server" RequestContainner="#Institutecource"
                    ResponseContainner="#Institutecource"
                    onajaxclick="AddICourceAjaxClick" >Add</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
