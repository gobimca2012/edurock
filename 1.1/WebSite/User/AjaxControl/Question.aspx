<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="User_AjaxControl_Question" %>

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
                <aspajax:HyperLink ID="lnkEdit" runat="server" ContainnerID="#contentBox">Edit</aspajax:HyperLink></div>
            <div style="clear: both">
            </div>
        </div>
        <div id="Question" style="padding: 5px;">
            <div>
                <div>
                    <span id="lblQuestionText" runat="server" class="btext"></span>
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
            <div>
                <div>
                    Post By &nbsp; <span id="user" runat="server" class="btext"></span>
                </div>
            </div>
            <div>
                <div>
                    Question Type : <span id="lblQuestionTypeID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    Question Status <span id="lblQuestionStatusID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Post Date</span>
                </div>
                <div>
                    <span id="lblModifiedDate" runat="server"></span>
                </div>
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
