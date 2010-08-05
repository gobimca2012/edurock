﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfo.aspx.cs" Inherits="College_Ajaxer_ExamViewInfo" %>

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
                            <span class="label">Cource</span>
                        </div>
                        <div id="ddin">
                            <asp:DropDownList ID="ddInstituteCource" runat="server">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div id="SubjectDrop">
                        <div>
                            <span class="label">Subject</span>
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
                            <span class="label">Examination Title</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtExamName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Subject Name</span>
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
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400px" CssClass="mceEditor" ></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Exam Time</span>
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
                            <span class="label">Required Pecentage</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtRequirePecentage" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Start Date</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">End Date</span>
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
                <aspajax:AjaxLinkButton ID="lnkAddExam" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn"> Add</div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateExam" runat="server" RequestContainner="#contentBox" EnableValidation="true"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn"> Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>