<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="ExamIntroduction.aspx.cs" Inherits="College_ExamIntroduction" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
</asp:Content>
