<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="College_Ajaxer_Question" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox" style="width: 100%; height: 100%">
        <div class="gray">
            <h3 id="Examname" runat="server">
            </h3>
        </div>
        <div class="whitecont">
            <div style="float: left; width: 530px">
                <div id="exami">
                    <div class="whitecont">
                        <div id="DivSingleChoice" runat="server">
                            <div>
                                <span id="lblQuestion" runat="server" class="label"></span>
                            </div>
                            <div>
                                <asp:RadioButtonList ID="chkOption" runat="server">
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div id="DivMultipleChoice" runat="server">
                            <div>
                                <span id="lblMultiQustion" runat="server" class="label"></span>
                            </div>
                            <div>
                                <asp:CheckBoxList ID="chkMulti" runat="server" />
                                <div id="multiCheck" runat="server">
                                </div>
                            </div>
                        </div>
                        <div id="divSingleFillIntheBlanck" runat="server">
                            <div>
                                <span id="lblPrefixText" runat="server"></span><span>
                                    <asp:DropDownList ID="ddAnswer" runat="server">
                                    </asp:DropDownList>
                                </span><span id="lblsufixText" runat="server"></span>
                            </div>
                        </div>
                        <div style="clear: both">
                            Marks : <span id="lblMarks" runat="server" class="label"></span>
                        </div>
                        <div style="clear: both">
                            <div style="float: left; padding: 5px;">
                                <aspajax:AjaxLinkButton ID="lnkPrev" runat="server" Text="Prev" RequestContainner="#exam"
                                    ResponseContainner="#exam" PostBackUrl="Question.aspx" OnAjaxClick="PrevAjaxClick"></aspajax:AjaxLinkButton></div>
                            <div style="float: left; padding: 5px;">
                                <aspajax:AjaxLinkButton ID="lnkNext" runat="server" Text="Next" RequestContainner="#exam"
                                    PostBackUrl="Question.aspx" ResponseContainner="#exam" OnAjaxClick="NextAjaxClick"></aspajax:AjaxLinkButton></div>
                            <div style="clear: both">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div style="float: right; width: 200px;">
                <div class="contentbox">
                    <asp:ListView ID="ListQuestion" runat="server" DataKeyNames="EXM_QuestionID" OnItemCommand="QuestionList_ItemCommand">
                        <LayoutTemplate>
                            <div>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div>
                                <div class="gbg">
                                    <h5>
                                        <aspajax:HyperLink ID="lnkOrder" runat="server" ContainnerID="#exam" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/Question.aspx")+"?oid="+Eval("Order") %>'><%#Eval("Order") %></aspajax:HyperLink></h5>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
            <div style="clear: both">
                <asp:LinkButton ID="lnkSubmit" runat="server"><div class="btn"> Finish</div></asp:LinkButton>
            </div>
        </div>
    </div>

    <script type="text/javascript">
//    Counter(0,6,60);
    function SubmitAnswer(PopUpID, Url)
    {   
   
   if(confirm("do you want to submit Examination answers?"))
   {
     $(PopUpID).html("");
    $("#contentBox").LoadPageNoReplace(Url);       
    
   }
    return false;
}
    </script>

    </form>
</body>
</html>
