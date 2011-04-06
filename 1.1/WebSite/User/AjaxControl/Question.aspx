﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="User_AjaxControl_Question" %>

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
                Question View
            </div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkEdit" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn editbtn"> <%=Resources.Default.Edit_Text %> </div></aspajax:HyperLink></div>
            <div style="float: right">
                <aspajax:HyperLink ID="lnkShare" runat="server" Visible="false" ContainnerID="#contentBox"><div class="btn">  Share Question</div></aspajax:HyperLink></div>
            <div style="clear: both">
            </div>
        </div>
        <div id="Question" class="whitecont">
            <div class="fuleft">
                <div>
                    <div>
                        <span id="lblQuestionText" runat="server" class="btitle"></span>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span>
                    </div>
                    <div>
                        <span id="lblDescription" runat="server"></span>
                    </div>
                </div>
                <div style="display: none;">
                    <div>
                        Question Type : <span id="lblQuestionTypeID" runat="server"></span>
                    </div>
                </div>
                <div style="display: none;">
                    <div>
                        Question Status <span id="lblQuestionStatusID" runat="server"></span>
                    </div>
                </div>
            </div>
            <div class="furight">
                <uc1:FullViewSideInfo ID="FullViewSideInfo1" runat="server" />
            </div>
            <div style="clear: both">
            </div>
        </div>
        <div>
            <div class="graycontent roundedall">
                <div id="Answer">
                </div>
            </div>
        </div>
        <div class="gray">
        </div>
    </div>
    </form>
</body>
</html>
