﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EducationInfo.aspx.cs" Inherits="User_AjaxControl_EducaonInfot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>UserEducation</legend>
            <div>
                
                <div>
                    <div>
                        <span class="label">InstitueName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtInstitueName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">SubjectName</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtSubjectName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Year</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                    </div>
                </div>
               
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddcource" runat="server" RequestContainner="#education"
                    ResponseContainner="#education" OnAjaxClick="AddAjaxClick">Add</aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdate" runat="server" RequestContainner="#education"
                    ResponseContainner="#education" OnAjaxClick="UpdateAjaxClick">Update</aspajax:AjaxLinkButton>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
