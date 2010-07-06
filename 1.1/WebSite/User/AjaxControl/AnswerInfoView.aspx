<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnswerInfoView.aspx.cs" Inherits="User_AjaxControl_AnswerInfoView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListAnswer" runat="server" DataKeyNames="LoginUserID,AnswerID"
            OnItemDataBound="ListAnswerOnItemDataBound">
            <LayoutTemplate>
                <div >
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <div>
                        <%#Eval("AnswerText") %>
                    </div>
                    <div>
                        <div>
                            <asp:Image ID="imgProf" runat="server" ImageUrl='<%#ResolveUrl(Eval("PhotoPath").ToString()) %>'
                                Width="100" />
                        </div>
                        Post By
                        <%#Eval("FirstName") %>
                        &nbsp;<%#Eval("LastName") %>
                    </div>
                    <div>
                        <%#Eval("Description") %>
                    </div>
                    <div>
                        <%#Eval("AnswerStatus") %>
                    </div>
                    <div>
                        Answer Rate
                        <%#Eval("AnswerRate") %>
                    </div>
                    <div>
                        <%#Eval("ModifiedDate") %>
                    </div>
                    <div id="UserAction" runat="server">
                        <div id="stateDiv" runat="server">
                            <asp:DropDownList ID="ddState" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div>
                            <%# _HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("AnswerID").ToString(), "#Answer", "#Answer")%>
                        </div>
                        <div>
                            <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/Admin/Ajaxer/AnswerInfo.aspx") + "?cid=" + Eval("AnswerID")%>'
                                ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                        </div>
                        <div id="acceptAnswer" runat="server">
                            <%#_HtmlHelper.ListViewLinkButton("lnkd", "accept Answer","accept", Eval("AnswerID").ToString(), "#Answer", "#Answer")%>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
        <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevAnswer" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick"
                        Pagger="true" Increment="false" RequestContainner="#Answer" ResponseContainner="#Answer"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextAnswer" runat="server" OnAjaxClick="NextAjaxClick"
                        RequestContainner="#Answer" Pagger="true" Increment="true" ResponseContainner="#Answer">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <aspajax:HyperLink ID="hpAddAnswer" runat="server" ContainnerID="#Answer">Add New</aspajax:HyperLink>
        </div>
    </div>
    </form>
</body>
</html>
