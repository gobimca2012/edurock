<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Expired.aspx.cs" Inherits="Expired" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="page">
            <div class="contentbox">
                <div class="whitecont">
                    <p>
                        Your product expired .please upgade your product using upgrade button and after
                        upgrade your product will be ready to use.we will remove your data after 10 days
                        of expriry date.
                    </p>
                    <div>
                        <asp:HyperLink ID="lnkUpgrade" runat="server"><div class="btn">Upgrade</div></asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
