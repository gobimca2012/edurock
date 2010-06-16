<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MultipleChoiceQuestion.ascx.cs" Inherits="College_UserControl_MultipleChoiceQuestion" %>
<div class="contentbox">
    <div>
        <span id="lblQuestion" runat="server" class="label"></span>
    </div>
    <div>
       <%-- <asp:ListView ID="listOption" runat="server">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <asp:CheckBox ID="chkOption" runat="server" Text='<%#Eval("Answer") %>' />
                </div>
            </ItemTemplate>
        </asp:ListView>--%>
        <asp:CheckBoxList ID="chkOption" runat="server"  />
    </div>
    <div>
       Marks : <span id="lblMarks" runat="server" class="label"></span>
    </div>
</div>
