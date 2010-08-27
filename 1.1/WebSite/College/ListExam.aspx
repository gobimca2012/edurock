<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="ListExam.aspx.cs" Inherits="College_ListExam" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div>
            <asp:HyperLink ID="lnkAdd" runat="server" NavigateUrl="~/College/AddExam.aspx"><%=Resources.Default.Add_Text%> Exam</asp:HyperLink>
        </div>
        <br />
        <asp:ListView ID="ListExam" runat="server" OnItemCommand="List_ItemCommand" DataKeyNames="ExamID">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                ExamName
                            </td>
                            <td>
                                SubjectName
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:HyperLink ID="lnkExam" runat="server" NavigateUrl='<%#ResolveUrl("~/College/ExamIntroduction.aspx")+"?eid="+Eval("ExamID") %>'>
                        <%#Eval("ExamName") %></asp:HyperLink>
                    </td>
                    <td>
                        <%#Eval("SubjectName") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                    </td>
                    <td>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/AddExam.aspx")+"?eid="+Eval("ExamID")%>'><%=Resources.Default.Edit_Text %></asp:HyperLink>
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Deletedata">Delete</asp:LinkButton>
                    </td>
                    <td>
                        <asp:HyperLink ID="lnkAddQuestion" runat="server" NavigateUrl='<%#ResolveUrl("~/College/QuestionWizard/Step1.aspx")+"?eid="+Eval("ExamID")%>'><%=Resources.Default.Add_Text%> Question</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="lnkListQuestion" runat="server" NavigateUrl='<%#ResolveUrl("~/College/QuestionWizard/ListQuestion.aspx")+"?eid="+Eval("ExamID")%>'>List Question</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="lnkListUser" runat="server" NavigateUrl='<%#ResolveUrl("~/College/ExamAttenders.aspx")+"?eid="+Eval("ExamID")%>'>List Exammer</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
