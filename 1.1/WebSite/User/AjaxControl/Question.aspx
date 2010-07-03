<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="User_AjaxControl_Question" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="Question">
            <div>
                <div>
                    <span class="label">QuestionID</span>
                </div>
                <div>
                    <span id="lblQuestionID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">QuestionText</span>
                </div>
                <div>
                    <span id="lblQuestionText" runat="server"></span>
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
                    <span class="label">LoginUserID</span>
                </div>
                <div>
                    <span id="lblLoginUserID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">QuestionTypeID</span>
                </div>
                <div>
                    <span id="lblQuestionTypeID" runat="server"></span>
                </div>
            </div>
            <div>
                <div>
                    <span class="label">QuestionStatusID</span>
                </div>
                <div>
                    <span id="lblQuestionStatusID" runat="server"></span>
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
            <asp:LinkButton ID="lnkedit" runat="server" Text="Edit" CssClass="btnlnk"></asp:LinkButton>
            <asp:LinkButton ID="lnkAddNew" runat="server" Text="Add" CssClass="btnlnk"></asp:LinkButton>
        </div>
    </div>
    <div>
        <div id="Answer">
        </div>
    </div>
    </form>
</body>
</html>
