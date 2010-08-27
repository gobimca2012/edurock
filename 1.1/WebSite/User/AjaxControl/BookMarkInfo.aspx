<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookMarkInfo.aspx.cs" Inherits="User_AjaxControl_BookMarkInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Image
        </div>
        <div class="whitecont">
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend>Document</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Bookmark url</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="300px"></asp:TextBox>
                        </div>
                    </div>
                
                    <div>
                        <div>
                            <span class="label">Tag</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtTag" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <div>
                               <cram:SpaceLabel ID="lblcc" runat="server" EnableViewState="false" CssClass="label"></cram:SpaceLabel><span class="valmsg" >(Required)*</span>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddCource" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div>
                            <div>
                                <cram:CategoryLabel ID="asa" runat="server" EnableViewState="false" CssClass="label"></cram:CategoryLabel><span class="valmsg" >(Required)*</span>
                            </div>
                            <div id="ddrep">
                                <asp:DropDownList ID="ddSubject" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddDocument" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"> <%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateDocument" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn"> Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
