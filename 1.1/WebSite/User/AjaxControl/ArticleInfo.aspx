<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ArticleInfo.aspx.cs" Inherits="User_AjaxControl_ArticleInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="gray">
            </div>
            <div class="whitecont">
                <div id="divMessage" runat="server">
                </div>
                <fieldset>
                    <legend>Article</legend>
                    <div>
                        <div>
                            <div>
                                <span class="label">Title</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Description</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">MetaDescription</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtMetaDescription" runat="server" TextMode="MultiLine" Height="300"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <div>
                                    <span class="label">Select your Cource</span>
                                </div>
                                <div>
                                    <asp:DropDownList ID="ddCource" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div>
                                <div>
                                    <span class="label">Select your Subject</span>
                                </div>
                                <div id="ddrep">
                                    <asp:DropDownList ID="ddSubject" runat="server">
                                    </asp:DropDownList>
                                </div>
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
                    </div>
                </fieldset>
            </div>
            <div class="gray">
                <div>
                    <aspajax:AjaxLinkButton ID="lnkAddArticle" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkUpdateArticle" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn">Update</div></aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
