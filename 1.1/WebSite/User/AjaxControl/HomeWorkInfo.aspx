<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeWorkInfo.aspx.cs" Inherits="User_AjaxControl_HomeWorkInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Home Work</div>
        <div>
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend>HomeWork</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Title</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" Height="187px" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">ShortDescription</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtShortDescription" runat="server" Height="292px" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div id="ddInsti">
                        <div>
                            <span class="label">Course</span> <span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:DropDownList ID="ddInstituteCource" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div id="ddSub">
                        <div>
                            <span class="label">Subject</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:DropDownList ID="ddInstituteSubject" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddHomeWork" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn">Save Home work</div> </aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateHomeWork" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn">Save Home work</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
