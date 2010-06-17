<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="StartExam.aspx.cs" Inherits="College_StartExam" Title="Untitled Page"
    EnableEventValidation="false" ValidateRequest="false" ViewStateEncryptionMode="Never"
    EnableViewStateMac="false" %>

<%@ Register Src="UserControl/Question.ascx" TagName="Question" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div style="float: left;" class="qs">
        <uc3:Question ID="Question1" runat="server" />
    </div>
    <div>
        Time Remain</div>
    <div>
        <span id="time"></span>
    </div>
</asp:Content>
