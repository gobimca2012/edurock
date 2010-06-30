<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceCatagoryInfoView.aspx.cs"
    Inherits="College_Ajaxer_CourceCatagoryInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListCourceCatagory" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                CourceCatagoryID
                            </td>
                            <td>
                                CatagoryName
                            </td>
                            <td>
                                LoginUserID
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                CatagoryType
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
                        <%#Eval("CourceCatagoryID") %>
                    </td>
                    <td>
                        <%#Eval("CatagoryName") %>
                    </td>
                    <td>
                        <%#Eval("LoginUserID") %>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("CatagoryType") %>
                    </td>
                    <td>
                        <%#Eval("ModifiedDate") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <asp:LinkButton ID="lnkPrev" runat="server" Text="Prev" OnClick="Prev_Click"></asp:LinkButton>
                </div>
                <div style="float: left">
                    <asp:LinkButton ID="lnkNext" runat="server" Text="Next" OnClick="Next_Click"></asp:LinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="lnkAdd" runat="server" NavigateUrl="CourceCatagoryInfo.aspx"
                ContainnerID="#courcecatagory">Add new</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
