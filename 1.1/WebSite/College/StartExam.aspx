<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StartExam.aspx.cs" Inherits="College_StartExam"
    Title="Untitled Page" EnableEventValidation="false" ValidateRequest="false" ViewStateEncryptionMode="Never"
    EnableViewStateMac="false" %>

<%@ Register Src="UserControl/Question.ascx" TagName="Question" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="qs">
        <div id="exam" style="width: 100%; height: 100%; position: fixed; top: 0; left: 0">
        </div>
        <div>
            <span id="time"></span>
        </div>
    </div>

    <script type="text/javascript">
        $(window).unload( function () { alert("Your examination hasbeen terminated you can continue this examination again"); } );
    </script>

    </form>
</body>
</html>
