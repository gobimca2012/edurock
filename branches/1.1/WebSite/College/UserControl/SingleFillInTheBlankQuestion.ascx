﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SingleFillInTheBlankQuestion.ascx.cs"
    Inherits="College_UserControl_SingleFillInTheBlankQuestion" %>
<div class="contentbox">
    <div>
        <span id="lblQuestion" runat="server" class="label"></span>
    </div>
    <div>
        <%--   <asp:ListView ID="listOption" runat="server">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <asp:RadioButton ID="chkOption" runat="server" Text='<%#Eval("Answer") %>' />
                </div>
            </ItemTemplate>
        </asp:ListView>--%>
        <span id="lblPrefixText" runat="server"></span><span>
            <asp:DropDownList ID="ddAnswer" runat="server">
            </asp:DropDownList>
        </span><span id="sufixText" runat="server"></span>
    </div>
    <div>
        Marks : <span id="lblMarks" runat="server" class="label"></span>
    </div>
</div>
