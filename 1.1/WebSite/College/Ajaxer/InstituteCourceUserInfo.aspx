<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceUserInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceUserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="gray">
            </div>
            <div class="whitecont">
                <div id="divMessage" runat="server">
                </div>
                <fieldset>
                    <legend>InstituteCourceUser</legend>
                    <div>
                        <div>
                            <div>
                                <span class="label">InstituteCourceID</span>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddCource" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">LoginUserID</span>
                            </div>
                            <div>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Type</span>
                            </div>
                            <div>
                            </div>
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class="gray">
                <div>
                    <aspajax:AjaxLinkButton ID="lnkAddInstituteCourceUser" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkUpdateInstituteCourceUser" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
