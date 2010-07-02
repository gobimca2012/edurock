<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteCourceInfoView.aspx.cs"
    Inherits="College_Ajaxer_InstituteCourceInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListInstituteCource" runat="server">
            <LayoutTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>
                                InstituteCourceID
                            </td>
                            <td>
                                InstituteID
                            </td>
                            <td>
                                CourceID
                            </td>
                            <td>
                                Modifieddate
                            </td>
                        </tr>
                    </thead>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("InstituteCourceID") %>
                    </td>
                    <td>
                        <%#Eval("InstituteID") %>
                    </td>
                    <td>
                        <%#Eval("Cource.CourceName")%>
                    </td>
                    <td>
                        <%#Eval("Cource.CourceCatagory.CatagoryName")%>
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
            <aspajax:HyperLink ID="lnkAddiCo" runat="server" ContainnerID="#Institutecource" NavigateUrl="~/College/Ajaxer/InstituteCourceInfo.aspx">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
