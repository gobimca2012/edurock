<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageInfoView.aspx.cs" Inherits="User_AjaxControl_ImageInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Images</div>
        <div class="graycontent">
            <div style="float: left" class="title">
                Search
            </div>
            <div style="float: right" class="exand" id="searchboxtrigger">
            </div>
            <div class="clear">
            </div>
            <div id="searchbox" runat="server" style="display: none">
                <div>
                    <div style="float: left;">
                        <div class="label">
                            Keyword</div>
                        <div>
                            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="float: left;">
                        <div class="label">
                            Start Date</div>
                        <div>
                            <asp:TextBox ID="txtstartDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="float: left;">
                        <div class="label">
                            End Date</div>
                        <div>
                            <asp:TextBox ID="txtEnddate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                    <div>
                        <aspajax:AjaxLinkButton ID="lnkSearch" runat="server" EnableValidation="False" EnableViewState="False"
                            Increment="False" OnAjaxClick="AjaxSearch" RequestContainner="#contentBox" ResponseContainner="#contentBox"
                            Pagger="False"><div class="btn">Search</div> </aspajax:AjaxLinkButton>
                    </div>
                </div>
            </div>
        </div>
        <asp:ListView ID="ListDocument" runat="server" DataKeyNames="ID" OnItemDataBound="ListDocumentOnItemDataBound">
            <LayoutTemplate>
                <%--<table>--%>
                <%--  <thead>
                        <tr>
                            <td>
                                Name
                            </td>
                            <td>
                                Description
                            </td>
                            <td>
                                MetaDescription
                            </td>
                            <td>
                                Tag
                            </td>
                            <td>
                                Rating
                            </td>
                            <td>
                                FilePath
                            </td>
                            <td>
                                DocumentType
                            </td>
                            <td>
                                ModifiedDate
                            </td>
                        </tr>
                    </thead>--%>
                <div class="whitecont">
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
                <%--  </table>--%>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="float: left;">
                    <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + Eval("ID").ToString()%>'>
                    <div style="max-height:150px;min-height:150px;">
                        <asp:Image ID="img" runat="server" ImageUrl='<%#ResolveUrl(Eval("Param1").ToString()) %>' Width="100" />
                    </div>
                    <div>
                      
                        <%#Eval("Title") %>
                    </div>
                    </aspajax:HyperLink>
                    
                        <%#_HtmlHelper.ListViewLinkButtonDelete("lnkd", "delete", Eval("ID").ToString(), Eval("LoginUserID").ToString(), "#contentBox", "#contentBox")%>
                    
                </div>
                <%--  <tr>
                    <td>
                        <aspajax:HyperLink ID="lnkFull" runat="server" ContainnerID="#contentBox" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/Document.aspx") + "?did=" + Eval("DocumentID").ToString()%>'>
                        <%#Eval("Name") %></aspajax:HyperLink>
                    </td>
                    <td>
                        <%#Eval("Description") %>
                    </td>
                    <td>
                        <%#Eval("MetaDescription") %>
                    </td>
                    <td>
                        <%#Eval("Tag") %>
                    </td>
                    <td>
                        <%#Eval("Rating") %>
                    </td>
                    <td>
                        <%#Eval("FilePath") %>
                    </td>
                    <td>
                        <%#Eval("DocumentType") %>
                    </td>
                    <td>
                        <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime( Eval("ModifiedDate").ToString())) %>
                    </td>
                    <td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("DocumentID").ToString(), "#contentBox", "#contentBox")%>
                    </td>
                    <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/User/AjaxControl/DocumentInfo.aspx") + "?dtype=1&did=" + Eval("DocumentID")%>'
                            ContainnerID="#contentBox">Edit</aspajax:HyperLink>
                    </td>
                </tr>--%>
            </ItemTemplate>
        </asp:ListView>
        <div style="clear: both">
        </div>
        <div class="gray">
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevDocument" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#contentBox" ResponseContainner="#contentBox"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextDocument" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#contentBox" Pagger="true" Increment="true" ResponseContainner="#contentBox">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="hpAddDocument" runat="server" NavigateUrl="~/User/AjaxControl/DocumentInfo.aspx?dtype=1"
                    ContainnerID="#contentBox"><div class="btn">Add New Image</div> </aspajax:HyperLink>
            </div>
        </div>
        <div style="clear: both">
        </div>
    </div>
    </form>
</body>
</html>
