<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionInfo.aspx.cs" Inherits="User_AjaxControl_QuestionInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
        </div>
        <div id="divMessage" runat="server">
        </div>
        <fieldset>
            <legend>Question</legend>
            <div>
                <div>
                    <div>
                        <span class="label">Title</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtQuestionText" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Description</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400px"></asp:TextBox>
                    </div>
                </div>
                <div>
                    <div>
                        <span class="label">Question Type</span><span class="valmsg" >(Required)*</span>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddQuestionType" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <div>
                    <div>
                        <div>
                        <cram:SpaceLabel ID="lblcc" runat="server" EnableViewState="false" CssClass="label"></cram:SpaceLabel><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:DropDownList ID="ddCource" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div id="divsubject" runat="server" visible="false">
                        <div>
                            <cram:CategoryLabel ID="asa" runat="server" EnableViewState="false" CssClass="label"></cram:CategoryLabel><span class="valmsg" >(Required)*</span>
                        </div>
                        <div id="ddrep">
                            <asp:DropDownList ID="ddSubject" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div>
                    <span class="label">Tags</span>
                </div>
                <div>
                    <asp:TextBox ID="txtTags" runat="server"></asp:TextBox>
                </div>
            </div>
        </fieldset>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddQuestion" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"><%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateQuestion" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
