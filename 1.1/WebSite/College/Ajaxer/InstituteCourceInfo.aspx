<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfo" EnableEventValidation="false" ValidateRequest="false" %>

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
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>InstituteCource</legend>
            <div>
                <div>
                    <div>
                        <span class="label">CourceID</span><span><aspajax:HyperLink ID="lnkAddCat" runat="server"
                            ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/CourceInfo.aspx">Add New Catagory</aspajax:HyperLink></span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCource" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">MetaDescription</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMetaDescription" runat="server" Height="203px" TextMode="MultiLine"
                            Width="670px" CssClass="mceEditor"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">MetaKeyword</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMetaKeyword" runat="server" Height="106px" TextMode="MultiLine"
                            Width="667px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">StartDate</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">EndDate</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">IsPublished</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkIsPublished" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">HomeWorkEnable</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkHomeWorkEnable" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">AttendanceEnable</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkAttendanceEnable" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">QuestionAnswerEnable</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkQuestionAnswerEnable" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">SelfRegistrationEnable</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkSelfRegistrationEnable" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">IsFree</span>
                    </div>
                    <div>
                        <asp:CheckBox ID="chkIsFree" runat="server" />
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Price</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </fieldset>
        <div class="gray">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkAddInstituteCource" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkUpdateInstituteCource" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn">Update</div></aspajax:AjaxLinkButton>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>

  <%--  <script language='javascript' type='text/javascript'>
tinyMCE.init({
mode : 'textareas',
theme : 'advanced',
theme_advanced_buttons1: "bold, italic,underline",
theme_advanced_buttons2:"",
theme_advanced_buttons3:"",
editor_selector : "mceEditor"

});
//you can also used “advanced” for themes
    </script>--%>

</body>
</html>
