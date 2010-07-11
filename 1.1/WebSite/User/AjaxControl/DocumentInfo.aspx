﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DocumentInfo.aspx.cs" Inherits="User_AjaxControl_DocumentInfo" %>

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
                            <span class="label">Name</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">MetaDescription</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtMetaDescription" runat="server"></asp:TextBox>
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
                            <span class="label">FilePath</span><span>
                                <asp:LinkButton ID="lnkFilePopUp" runat="server">Upload Image</asp:LinkButton></span>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddDocument" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateDocument" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
