<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InstituteSubjectInfoView.aspx.cs" Inherits="College_Ajaxer_InstituteSubjectController" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
		
		<asp:ListView ID="ListInstituteSubject" runat="server">
        <LayoutTemplate>
            <table>
                <thead>
                    <tr>
					
                      
                        <td>
                            SubjectText
                        </td>
						
                        
						
                        <td>
                            ModifiedDate
                        </td>
						
						
                    </tr>
                </thead>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
			    
                
				
                <td>
                     <%#Eval("SubjectText") %>
                </td>
				
                
				
                <td>
                     <%#Eval("ModifiedDate") %>
                </td>
				
				<td>
                        <%#_HtmlHelper.ListViewLinkButton("lnkd", "delete", Eval("InstituteSubjectID").ToString(), "#courceinfo", "#courceinfo")%>
                    </td>
					 <td>
                        <aspajax:HyperLink ID="lnkedit" runat="server" NavigateUrl='<%#ResolveUrl("~/College/Ajaxer/InstituteSubjectInfo.aspx") + "?isid=" + Eval("InstituteSubjectID")%>'
                            ContainnerID="#courceinfo">Edit</aspajax:HyperLink>
                    </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
	 <div>
            <div style="float: right">
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkPrevInstituteSubject" runat="server" Text="Prev" OnAjaxClick="PrevAjaxClick" Pagger="true" Increment="false"
                         RequestContainner="#courceinfo" ResponseContainner="#courceinfo"></aspajax:AjaxLinkButton>
                </div>
                <div style="float: left">
                    <aspajax:AjaxLinkButton ID="lnkNextInstituteSubject" runat="server" OnAjaxClick="NextAjaxClick" RequestContainner="#courceinfo" Pagger="true" Increment="true"
                        ResponseContainner="#courceinfo">Next</aspajax:AjaxLinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
	<div>
            <aspajax:HyperLink ID="hpAddInstituteSubject" runat="server" 
                ContainnerID="#courceinfo">Add New</aspajax:HyperLink>
        </div>
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
    </div>
    </form>
</body>
</html>
