<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCource.aspx.cs"
    Inherits="College_Ajaxer_InstituteCource" %>

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
        <div id="InstituteCource" class="whitecont">
            <div>
                <aspajax:HyperLink ID="lnkback" runat="server" Text="back to List" ContainnerID="#courceinfo"
                    NavigateUrl="~/College/Ajaxer/InstituteCourceInfoView.aspx"></aspajax:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">InstituteCourceID</span>
                </div>
                <div>
                    <span id="lblInstituteCourceID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">InstituteID</span>
                </div>
                <div>
                    <span id="lblInstituteID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">CourceID</span>
                </div>
                <div>
                    <span id="lblCourceID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">MetaDescription</span>
                </div>
                <div>
                    <span id="lblMetaDescription" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">MetaKeyword</span>
                </div>
                <div>
                    <span id="lblMetaKeyword" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">StartDate</span>
                </div>
                <div>
                    <span id="lblStartDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">EndDate</span>
                </div>
                <div>
                    <span id="lblEndDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">IsPublished</span>
                </div>
                <div>
                    <span id="lblIsPublished" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">HomeWorkEnable</span>
                </div>
                <div>
                    <span id="lblHomeWorkEnable" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">AttendanceEnable</span>
                </div>
                <div>
                    <span id="lblAttendanceEnable" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">QuestionAnswerEnable</span>
                </div>
                <div>
                    <span id="lblQuestionAnswerEnable" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">SelfRegistrationEnable</span>
                </div>
                <div>
                    <span id="lblSelfRegistrationEnable" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">IsFree</span>
                </div>
                <div>
                    <span id="lblIsFree" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Price</span>
                </div>
                <div>
                    <span id="lblPrice" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Modifieddate</span>
                </div>
                <div>
                    <span id="lblModifieddate" runat="server"></span>
                </div>
            </div>
        </div>
        <div class="gray">
            <asp:LinkButton ID="lnkedit" runat="server"><div class="bnt">Edit</div></asp:LinkButton>
            <asp:LinkButton ID="lnkAddNew" runat="server"><div class="btn">Add</div></asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
