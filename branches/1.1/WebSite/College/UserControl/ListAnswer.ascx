<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListAnswer.ascx.cs" Inherits="College_UserControl_ListAnswer" %>
<div class="contentbox">
    <asp:HyperLink ID="lnkAddAnswer" runat="server">Add Answer</asp:HyperLink>
    <asp:ListView ID="ListEXM_Answer" runat="server" OnItemCommand="ListAnswer_ItemCommand"
        DataKeyNames="EXM_AnswerID">
        <LayoutTemplate>
            <table>
                <thead>
                    <tr>
                        <td>
                            Answer
                        </td>
                        <td>
                            IsRight
                        </td>
                        <td>
                            ModifiedDate
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
                    <%#Eval("Answer") %>
                </td>
                <td>
                    <%#Eval("IsRight") %>
                </td>
                <td>
                    <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                </td>
                <td>
                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="DeleteAnswer">Delete</asp:LinkButton>
                </td>
                <td>
                    <asp:HyperLink ID="lnkEdit" runat="server">Edit</asp:HyperLink>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</div>
