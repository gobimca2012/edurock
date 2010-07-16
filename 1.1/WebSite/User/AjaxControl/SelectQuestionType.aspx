<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectQuestionType.aspx.cs"
    Inherits="User_AjaxControl_SelectQuestionType" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
        </div>
        <div class="whitecont">
            <div class="btn">
                <aspajax:HyperLink ID="lnkSingleChoice" runat="server" ContainnerID="#contentBox">Single Choice Question</aspajax:HyperLink>
            </div>
            <div class="btn">
                <aspajax:HyperLink ID="lnkMultiChoice" runat="server" ContainnerID="#contentBox">Multiple Choice Question</aspajax:HyperLink>
            </div>
            <div class="btn">
                <aspajax:HyperLink ID="lnksingleFillinTheBlank" runat="server" ContainnerID="#contentBox">Single Fill in the Blank</aspajax:HyperLink>
            </div>
            <div class="btn">
                <aspajax:HyperLink ID="lnkMultipleFillIntheBlank" runat="server" ContainnerID="#contentBox">Multiple Fill in the Blank</aspajax:HyperLink>
            </div>
            <div class="btn">
                <aspajax:HyperLink ID="lnkMatchword" runat="server" ContainnerID="#contentBox">Match Words</aspajax:HyperLink>
            </div>
        </div>
        <div class="gray">
        </div>
    </div>
    </form>
</body>
</html>
