<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exam.aspx.cs" Inherits="User_AjaxControl_Exam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Exam <span>
                <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink></span>
            <span>
                <aspajax:HyperLink ID="lnkQuestion" runat="server" ContainnerID="#contentBox">Questions</aspajax:HyperLink></span>
        </div>
        <div id="Exam" style="padding: 5px;">
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Exam/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">ExamID</span>
                </div>
                <div>
                    <span id="lblExamID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ExamName</span>
                </div>
                <div>
                    <span id="lblExamName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">SubjectName</span>
                </div>
                <div>
                    <span id="lblSubjectName" runat="server"></span>
                </div>
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
                    <span class="label">InstituteSubjectID</span>
                </div>
                <div>
                    <span id="lblInstituteSubjectID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Description</span>
                </div>
                <div>
                    <span id="lblDescription" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">LoginUserID</span>
                </div>
                <div>
                    <span id="lblLoginUserID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ModifiedDate</span>
                </div>
                <div>
                    <span id="lblModifiedDate" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ExamTime</span>
                </div>
                <div>
                    <span id="lblExamTime" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">IsActive</span>
                </div>
                <div>
                    <span id="lblIsActive" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">RequirePecentage</span>
                </div>
                <div>
                    <span id="lblRequirePecentage" runat="server"></span>
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
        </div>
        <div class="gray">
        </div>
    </div>
    </form>
</body>
</html>
