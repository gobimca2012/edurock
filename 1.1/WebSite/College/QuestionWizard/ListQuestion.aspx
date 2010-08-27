<%@ Page Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="ListQuestion.aspx.cs" Inherits="College_QuestionWizard_ListQuestion"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contentbox">
        <div>
            <asp:HyperLink ID="lnkAddQuestion" runat="server"><%=Resources.Default.Add_Text%> Question</asp:HyperLink>
        </div>
        <br />
        <div>
            <asp:ListView ID="ListEXM_Question" runat="server" OnItemCommand="ListQuestion_ItemCommand"
                DataKeyNames="EXM_QuestionID">
                <LayoutTemplate>
                    <table id="ListQuestion">
                        <thead>
                            <tr>
                                <td>
                                    Question
                                </td>
                                <td>
                                    Q_Type
                                </td>
                                <td>
                                    Description
                                </td>
                                <td>
                                    Date
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </thead>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr id='<%#"foo_"+Eval("EXM_QuestionID")%>'>
                        <td>
                            <%#Eval("Question") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetQuestionType(Convert.ToInt32(Eval("Q_Type")) )%>
                        </td>
                        <td>
                            <%#Eval("Description") %>
                        </td>
                        <td>
                            <%#BusinessLogic.CommonController.GetDate(Convert.ToDateTime(Eval("ModifiedDate"))) %>
                        </td>
                        <td>
                            <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/QuestionWizard/Step1.aspx")+"?qid="+Eval("EXM_QuestionID")%>'><%=Resources.Default.Edit_Text %></asp:HyperLink>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkDelete" runat="server" CommandName="DeleteQuestion" runat="server">Delete</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
    <div id="aaa">
    </div>

    <script type="text/javascript">
$('#ListQuestion').sortable(
{
    
    items : 'tr',
   update : function(event, ui)
   {
      var data = $('#ListQuestion').sortable('serialize');
       alert(data);
      // var myNewString = data.replace("&", "$");
      // myNewString = data.replace("[]", "");
      // alert(myNewString);

      $('#aaa').LoadPage('<%=ResolveUrl("~/Ordering.aspx") %>?qui=t&' + data);
   }
}
);
$("#ListQuestion").disableSelection();
    </script>

</asp:Content>
