<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Cource.aspx.cs" Inherits="College_Cource" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="Cource">
        <div>
            <asp:HyperLink ID="lnkback" runat="server" Text="back to List" runat="server" NavigateUrl="~/Modules/Cource/List.aspx"></asp:HyperLink>
        </div>
        <div>
            <div>
                <span class="label">CourceID</span>
            </div>
            <div>
                <span id="lblCourceID" runat="server"></span>
            </div>
        </div>
        <div>
            <div>
                <span class="label">CourceCatagoryID</span>
            </div>
            <div>
                <span id="lblCourceCatagoryID" runat="server"></span>
            </div>
        </div>
        <div>
            <div>
                <span class="label">CourceName</span>
            </div>
            <div>
                <span id="lblCourceName" runat="server"></span>
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
                <span class="label">CourceType</span>
            </div>
            <div>
                <span id="lblCourceType" runat="server"></span>
            </div>
        </div>
        <div>
            <div>
                <span class="label">Modifieddate</span>
            </div>
            <div>
                <span id="lblModifieddate" runat="server"></span>
            </div>
        </div>
        <asp:LinkButton ID="lnkedit" runat="server" Text="Edit" CssClass="btnlnk"></asp:LinkButton>
        <asp:LinkButton ID="lnkAddNew" runat="server" Text="Add" CssClass="btnlnk"></asp:LinkButton>
    </div>
</asp:Content>
