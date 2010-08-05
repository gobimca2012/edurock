﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourceInfo.aspx.cs" Inherits="College_Ajaxer_CourceInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="iCource" class="contentbox">
        <div id="divMessage" runat="server">
        </div>
        <div class="whitecont">
            <fieldset>
                <legend>Cource</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Cource Catagory</span>
                        </div>
                        <div>
                            <asp:DropDownList ID="ddCatagory" runat="server" Height="22px" Width="451px">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Cource Name</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtCourceName" runat="server" Width="454px"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" Height="193px" TextMode="MultiLine"
                                Width="457px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddcource" runat="server" RequestContainner="#iCource"
                    EnableValidation="true" ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#iCource" Visible="false"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
            </div>
            <%--<asp:HiddenField ID="_AjaxState" runat="server" />--%>
        </div>
    </div>
    </form>
</body>
</html>