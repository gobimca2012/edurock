<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookMark.aspx.cs" Inherits="User_AjaxControl_Document" %>

<%@ Register Src="../UserControl/FullViewSideInfo.ascx" TagName="FullViewSideInfo"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <div style="float: left">
                Bookmark</div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkEdit" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn editbtn"> <%=Resources.Default.Edit_Text %></div> </aspajax:HyperLink>
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkShare" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn editbtn">  Share </div></aspajax:HyperLink></div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkHistory" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn editbtn">  History </div></aspajax:HyperLink></div>
            <div style="clear: both">
            </div>
        </div>
        <div class="whitecont">
            <div class="fuleft">
                <div>
                    <div>
                        <asp:HyperLink ID="lblName" runat="server" class="btitle" Target="_blank"></asp:HyperLink>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <p id="lblDescription" runat="server">
                        </p>
                    </div>
                </div>
                <div style="display: none">
                    <div>
                        <span class="label">Tag</span>
                    </div>
                    <div>
                        <span id="lblTag" runat="server"></span>
                    </div>
                </div>
                <div style="display: none">
                    <div>
                        <span class="label">Rating</span>
                    </div>
                    <div>
                        <span id="lblRating" runat="server"></span>
                    </div>
                </div>
            </div>
            <div class="furight">
                <uc1:FullViewSideInfo ID="FullViewSideInfo1" runat="server" />
            </div>
            <div style="clear: both">
            </div>
            <div id="comment">
            </div>
            <div id="newcommentbox">
            </div>
        </div>
        <div class="gray">
          
        </div>
    </div>
    </form>
</body>
</html>
