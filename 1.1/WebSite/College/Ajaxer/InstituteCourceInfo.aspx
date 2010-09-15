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
            <legend>Cource</legend>
            <div>
                <%-- <div>
                    <div>
                        <cram:SpaceLabel ID="lblcc" runat="server" EnableViewState="false" CssClass="label"></cram:SpaceLabel><span class="valmsg" >(Required)*</span>
                        <div>
                            In case your cource not available in <cram:SpaceLabel ID="SpaceLabel1" runat="server"></cram:SpaceLabel>  Dropdown add new Cource using Add new
                            Base <cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel> 
                        </div>
                        <div>
                            <aspajax:HyperLink ID="lnkAddCat" runat="server" ContainnerID="#contentBox" NavigateUrl="~/College/Ajaxer/CourceInfo.aspx"><%=Resources.Default.Add_Text%> Base Cource</aspajax:HyperLink>
                        </div>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCource" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>--%>
                <div>
                    <cram:SpaceLabel ID="ttspace" runat="server"></cram:SpaceLabel>
                </div>
                <div>
                    <asp:TextBox ID="txtCourceName" runat="server"></asp:TextBox>
                </div>
                <div>
                    <div>
                        <span class="label">
                            <cram:SpaceLabel ID="SpaceLabel1" runat="server"></cram:SpaceLabel>
                            Catagory</span><span class="valmsg">(Required)*</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddCatagory" runat="server" Height="22px" Width="451px">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Meta Description</span><span class="valmsg">(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMetaDescription" runat="server" Height="203px" TextMode="MultiLine"
                            Width="670px" CssClass="mceEditor"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Meta Keyword</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtMetaKeyword" runat="server" Height="106px" TextMode="MultiLine"
                            Width="667px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Start Date</span><span class="valmsg">(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">End Date</span><span class="valmsg">(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div style="display:none">
                    <div>
                        <div>
                            <asp:CheckBox ID="chkIsPublished" runat="server" Text="IsPublished" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <asp:CheckBox ID="chkHomeWorkEnable" runat="server" Text="HomeWork Enable" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkAttendanceEnable" runat="server" Text="Attendance Enable" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkQuestionAnswerEnable" runat="server" Text="QuestionAnswer Enable" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkSelfRegistrationEnable" runat="server" Text="SelfRegistration Enable" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label"></span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkIsFree" runat="server" Text="Free Course" />
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
            </div>
        </fieldset>
        <div class="gray">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkAddInstituteCource" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"> <%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkUpdateInstituteCource" runat="server" RequestContainner="#contentBox"
                    Visible="false" ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
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
