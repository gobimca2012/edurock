<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="ShoppingCart_AjaxControl_Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="Product">
            <div>
                <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Product/List.aspx"></asp:HyperLink>
            </div>
            <div>
                <div>
                    <span class="label">ProductID</span>
                </div>
                <div>
                    <span id="lblProductID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Name</span>
                </div>
                <div>
                    <span id="lblName" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ItemType</span>
                </div>
                <div>
                    <span id="lblItemType" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">Price</span>
                </div>
                <div>
                    <span id="lblPrice" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">QuantityText</span>
                </div>
                <div>
                    <span id="lblQuantityText" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ApplicationURL</span>
                </div>
                <div>
                    <span id="lblApplicationURL" runat="server"></span>
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
                    <span class="label">MetaDescription</span>
                </div>
                <div>
                    <span id="lblMetaDescription" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">ModifiedDate</span>
                </div>
                <div>
                    <span id="lblModifiedDate" runat="server"></span>
                </div>
            </div>
            <div>
                <aspajax:HyperLink ID="lnkBuy" runat="server" ContainnerID="#contentBox"><div class="btn">Buy Now</div></aspajax:HyperLink>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
