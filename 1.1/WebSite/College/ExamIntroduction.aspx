
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamIntroduction.aspx.cs" Inherits="College_ExamIntroduction" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body >
    <form id="form1" runat="server">
    <div>
     <div class="contentbox">
        <div id="Exam">
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
                    <span class="label">Description</span>
                </div>
                <div>
                    <span id="lblDescription" runat="server"></span>
                </div>
            </div>
        </div>
        <div>
            <asp:HyperLink ID="lnkStartExam" runat="server" NavigateUrl="~/College/StartExam.aspx">Start Exam</asp:HyperLink>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
