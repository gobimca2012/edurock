<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<%@ Register src="Modules/Login/Login.ascx" tagname="Login" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="login"  style="margin:0 auto;position:absolute;left:500px">
            <div class="top">
            </div>
            <div class="mid">
            
                <uc1:Login ID="Login1" runat="server" />
            
            </div>
            <div class="bot">
            </div>
        </div>
    </div>
        <script type="text/javascript">
    $(document).ready(function()
    {
    $(".login").animate({ 
           
           
           top:"100"
  }, 1500 );
});
    
    </script>
    </form>
</body>
</html>
