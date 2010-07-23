<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteTypeAccessInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteTypeAccessInfo" %>

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
        <div class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend>User Role Access</legend>
                <div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddExam" runat="server" Text="CanAddExam" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddQuestion" runat="server" Text="CanAddQuestion" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddUser" runat="server" Text="CanAddUser" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddCource" runat="server" Text="CanAddCource" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddSubject" runat="server" Text="CanAddSubject" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddAudio" runat="server" Text="CanAddAudio" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddImage" runat="server" Text="CanAddImage" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddDocument" runat="server" Text="CanAddDocument" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddVideo" runat="server" Text="CanAddVideo" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddHomeWork" runat="server" Text="CanAddHomeWork" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddEvent" runat="server" Text="CanAddEvent" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddArticle" runat="server" Text="CanAddArticle"/>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddInstituteTypeAccess" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn">Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateInstituteTypeAccess" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
