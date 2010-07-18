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
                <legend>InstituteTypeAccess</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">InstituteTypeAccessID</span>
                        </div>
                        <div>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">InstituteUserTypeID</span>
                        </div>
                        <div>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddExam</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddExam" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddQuestion</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddQuestion" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddUser</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddUser" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddCource</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddCource" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddSubject</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddSubject" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddAudio</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddAudio" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddImage</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddImage" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddDocument</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddDocument" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddVideo</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddVideo" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddHomeWork</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddHomeWork" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddEvent</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddEvent" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">CanAddArticle</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkCanAddArticle" runat="server" />
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
