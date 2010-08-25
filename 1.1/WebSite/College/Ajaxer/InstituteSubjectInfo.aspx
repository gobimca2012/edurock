﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteSubjectInfo.aspx.cs"
    Inherits="College_Ajaxer_InstituteSubjectInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            <cram:CategoryLabel ID="asa" runat="server" EnableViewState="false" CssClass="label"></cram:CategoryLabel>
        </div>
        <div >
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend> <cram:CategoryLabel ID="sdf" runat="server" EnableViewState="false" CssClass="label"></cram:CategoryLabel></legend>
                <div>
                    <div>
                        <div>
                            <span class="label"><cram:CategoryLabel ID="lblcat" runat="server" ></cram:CategoryLabel> Title</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtSubjectText" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkAddInstituteSubject" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div style="float: left">
                <aspajax:AjaxLinkButton ID="lnkUpdateInstituteSubject" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn"> Update</div></aspajax:AjaxLinkButton>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
