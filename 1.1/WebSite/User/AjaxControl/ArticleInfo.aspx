<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ArticleInfo.aspx.cs" Inherits="User_AjaxControl_ArticleInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="gray">
            </div>
            <div class="whitecont">
                <div id="divMessage" runat="server">
                </div>
                <fieldset>
                    <legend>Article</legend>
                    <div>
                        <div>
                            <div>
                                <span class="label">Title</span><span class="valmsg">(Required)*</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Description</span><span class="valmsg">(Required)*</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400"
                                    CssClass="mceEditor"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">MetaDescription</span><span class="valmsg">(Required)*</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtMetaDescription" runat="server" TextMode="MultiLine" Height="300"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            <div>
                                <div>
                                    <span class="label">Select your Cource</span><span class="valmsg">(Required)*</span>
                                </div>
                                <div>
                                    <asp:DropDownList ID="ddCource" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div>
                                <div>
                                    <span class="label">Select your Subject</span><span class="valmsg">(Required)*</span>
                                </div>
                                <div id="ddrep">
                                    <asp:DropDownList ID="ddSubject" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div>
                                <span class="label">Tag</span>
                            </div>
                            <div>
                                <asp:TextBox ID="txtTag" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class="gray">
                <div>
                    <aspajax:AjaxLinkButton ID="lnkAddArticle" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"> Add</div></aspajax:AjaxLinkButton>
                </div>
                <div>
                    <aspajax:AjaxLinkButton ID="lnkUpdateArticle" runat="server" RequestContainner="#contentBox"
                        ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
    
   

// JavaScript Document
tinyMCE.init(
{
   mode : "textareas",
   theme : "advanced",
   theme_advanced_buttons1 : "mybutton,bold,italic,underline,separator,strikethrough,justifyleft,justifycenter,justifyright, justifyfull,bullist,numlist,undo,redo,link,unlink",
   theme_advanced_buttons2 : "",
   theme_advanced_buttons3 : "",
   theme_advanced_toolbar_location : "top",
   theme_advanced_toolbar_align : "left",
   theme_advanced_statusbar_location : "bottom",
   plugins : 'inlinepopups',
   editor_selector : 'mceEditor',
   setup : function(ed)
   {
      // Add a custom button
      ed.addButton('mybutton',
      {
         title : 'My button',         
         onclick : function()
         {
            vteditor=ed;
            ed.focus();
            //ed.selection.setContent('<strong>Hello world!</strong>');
            $('#ipop').PUIWEditor('/WebSite/User/UploadPhoto.aspx?uptype=6','500','500');
         }
      });
   }
}
);



    </script>

    </form>
</body>
</html>
