<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamList.aspx.cs" Inherits="Modules_OnLineExam_ExamList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListExam" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                ExamID
                            </td>
                            <td>
                                ExamName
                            </td>
                            <td>
                                SubjectName
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("ExamID") %>
                    </td>
                    <td>
                        <%#Eval("ExamName") %>
                    </td>
                    <td>
                        <%#Eval("SubjectName") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                    <td>
                        <aspajax:AjaxLinkButton ID="lnkDelete" runat="server" Text="Delete" AjaxCommand="delete"  RequestContainner="#addque" PostBackUrl="ExamList.aspx" QID=' <%#Eval("ExamID").ToString() %>' ></aspajax:AjaxLinkButton>
                    </td>
                    <td>
                        <aspajax:AjaxLinkButton ID="lnkEdit" runat="server" Text="Edit" AjaxCommand="edit"  RequestContainner="#addque" PostBackUrl="AddExam.aspx" QID=' <%#Eval("ExamID").ToString() %>' ></aspajax:AjaxLinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
