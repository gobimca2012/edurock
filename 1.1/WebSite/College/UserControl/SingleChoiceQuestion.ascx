<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SingleChoiceQuestion.ascx.cs"
    Inherits="College_UserControl_SingleChoiceQuestion" %>
<%@ Register src="MultipleChoiceQuestion.ascx" tagname="MultipleChoiceQuestion" tagprefix="uc1" %>
<%@ Register src="SingleFillInTheBlankQuestion.ascx" tagname="SingleFillInTheBlankQuestion" tagprefix="uc2" %>
<div class="contentbox">
    <div>
        <span id="lblQuestion" runat="server" class="label"></span>
    </div>
    <div>
        <asp:ListView ID="listOption" runat="server" OnItemDataBound="ListAnswer_ItemBound">
            <LayoutTemplate>
                <div>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div>
                    <asp:RadioButton ID="chkOption" runat="server" Text='<%#Eval("Answer") %>' GroupName="Group1" />
                </div>
            </ItemTemplate>
        </asp:ListView>
        <asp:RadioButtonList ID="chkOption" runat="server">
        </asp:RadioButtonList>
    </div>
    <div>
    </div>
    <div>
        Marks : <span id="lblMarks" runat="server" class="label"></span>
    </div>
    <div>
    <asp:LinkButton ID="lnkNext" runat="server" onclick="lnkNext_Click1">Next Question</asp:LinkButton>
    </div>
</div>

<script type="text/javascript">
function SetSingleRadioButton(nameregex, current) {
        re = new RegExp(nameregex);
        for (i = 0; i < document.forms[0].elements.length; i++) {
            elm = document.forms[0].elements[i]
            if (elm.type == 'radio') {
                if (re.test(elm.name)) {
                    elm.checked = false;
                }
            }
        }
        current.checked = true;
    }
</script>



