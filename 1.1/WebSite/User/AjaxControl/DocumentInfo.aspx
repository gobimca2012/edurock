<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocumentInfo.aspx.cs" Inherits="User_AjaxControl_DocumentInfo" %>

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
                            <span class="label">Title</span><span class="valmsg" >(Required)*</span>
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
                            <span class="label">Meta Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtMetaDescription" runat="server" TextMode="MultiLine" Height="200px"></asp:TextBox>
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
                                <span class="label">Select your Cource</span><span class="valmsg" >(Required)*</span>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddCource" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Select your Subject</span><span class="valmsg" >(Required)*</span>
                            </div>
                            <div id="ddrep">
                                <asp:DropDownList ID="ddSubject" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div id="popupresponce">
                            <div id="newAdd" runat="server">
                                <div>
                                    <asp:Image ID="img" runat="server" Width="100" />
                                </div>
                                <div>
                                    <asp:HiddenField ID="filePath" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div>
                            <span class="label">FilePath</span><span><span class="valmsg" >(Required)*</span>
                                <asp:LinkButton ID="lnkFilePopUp" runat="server">Upload Image</asp:LinkButton></span>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddDocument" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateDocument" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
