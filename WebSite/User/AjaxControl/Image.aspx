<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image.aspx.cs" Inherits="User_AjaxControl_Image" EnableEventValidation="false" EnableViewState="false" EnableViewStateMac="false" ValidateRequest="false" ViewStateEncryptionMode="Never"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="formImage" runat="server" method="post" action="/User/AjaxControl/Image.aspx" >
    <div>
        <div>
            <asp:FileUpload ID="fl" runat="server" />
        </div>
        <div>
            <asp:TextBox ID="txtAA" runat="server"></asp:TextBox>
        </div>
        <input type="submit" value="Submit" />
       <%-- <a href="#" onclick=" $('#formImage').submit();">aaaa</a>--%>
        <aspajax:AjaxLinkButton ID="lnkAa" runat="server" RequestContainner="#contentBox"
            ResponseContainner="#contentBox">Hello</aspajax:AjaxLinkButton>
    </div>

    <script type="text/javascript">
    $('form').iframePostForm
    ({
         post : function ()
        {
            alert("aa");
        },
        complete : function (response)
        {
            alert(response);
        }
    });
   
    </script>

    </form>
</body>
</html>
