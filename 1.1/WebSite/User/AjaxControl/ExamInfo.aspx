<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfo.aspx.cs" Inherits="College_Ajaxer_ExamViewInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="gray">
            Exam
        </div>
        <div id="divMessage" runat="server">
        </div>
        <div class="whitecont">
            <fieldset>
                <legend>Exam</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">InstituteCourceID</span>
                        </div>
                        <div id="ddin">
                            <asp:DropDownList ID="ddInstituteCource" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div id="SubjectDrop">
                        <div>
                            <span class="label">InstituteSubjectID</span>
                        </div>
                        <div>
                            <div>
                                <asp:DropDownList ID="ddInstituteSubject" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">ExamName</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtExamName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">SubjectName</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtSubjectName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400px"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">ExamTime</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtExamTime" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">IsActive</span>
                        </div>
                        <div>
                            <asp:CheckBox ID="chkIsActive" runat="server" />
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">RequirePecentage</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtRequirePecentage" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">StartDate</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">EndDate</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddExam" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateExam" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
