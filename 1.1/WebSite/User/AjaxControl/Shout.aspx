<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shout.aspx.cs" Inherits="User_AjaxControl_Shout" %>

<%@ Register Src="../UserControl/FullViewSideInfo.ascx" TagName="FullViewSideInfo"
    TagPrefix="uc1" %>
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
        <div class="whitecont">
            <div class="fuleft">
                <div>
                    
                    <div>
                       
                        <div>
                            <p id="lblDescription" runat="server">
                            </p>
                        </div>
                    </div>
                   
                    <div style="display: none">
                        <div>
                            <span class="label">Tag</span>
                        </div>
                        <div>
                            <span id="lblTag" runat="server"></span>
                        </div>
                    </div>
                    <div style="display: none">
                        <div>
                            <span class="label">Rating</span>
                        </div>
                        <div>
                            <span id="lblRating" runat="server"></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="furight">
                <uc1:FullViewSideInfo ID="FullViewSideInfo1" runat="server" />
            </div>
            <div style="clear: both">
            </div>
            <div id="comment">
            </div>
            <div id="newcommentbox">
            </div>
            <div class="gray">
            </div>
        </div>
 
    </div>

    </form>
</body>
</html>
