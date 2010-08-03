<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Education.ascx.cs" Inherits="User_UserControl_AccountSetting_Education" %>
<div class="contentbox">
    <div id="divMessage" runat="server">
    </div>
    <fieldset>
        <legend>UserEducation</legend>
        <table>
            
            <tr>
                <td>
                    <span class="label">InstitueName</span>
                </td>
                <td>
                    <asp:TextBox ID="txtInstitueName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">SubjectName</span>
                </td>
                <td>
                    <asp:TextBox ID="txtSubjectName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <span class="label">Year</span>
                </td>
                <td>
                    <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                </td>
            </tr>
           
        </table>
    </fieldset>
    <div>
        <div >
            <asp:LinkButton ID="lnkAdd" runat="server" OnClick="lnkAdd_Click">Add</asp:LinkButton>
        </div>
       
    </div>
</div>
