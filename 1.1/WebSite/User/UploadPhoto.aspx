<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadPhoto.aspx.cs" Inherits="User_UploadPhoto"
    %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background: #fff">
    <form id="form1" runat="server">
    <div class="contentbox">
        <div class="whitecont">
            <div id="tabs">
                <ul>
                    <li><a href="#tabs-1">Upload new File</a></li>
                    <li><a href="#tabs-2">Repository</a></li>
                </ul>
                <div id="tabs-1">
                    <div id="divMessage" runat="server">
                    </div>
                    <div>
                        Upload File
                    </div>
                    <div>
                        <asp:FileUpload ID="fileUploader" runat="server" />
                    </div>
                    <div>
                        <asp:LinkButton ID="lnkUpload" runat="server" OnClick="lnkUpload_Click"><div class="btn editbtn"> Upload</div></asp:LinkButton>
                    </div>
                    <asp:Label ID="injectScript" runat="server"></asp:Label>
                </div>
                <div id="tabs-2">
                    <asp:DataList ID="ListImage" runat="server" OnItemCommand="OnImageListItemCommand"
                        DataKeyField="FilePath" RepeatColumns="3">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkUplo" runat="server" CommandName="upload">
                                <asp:Image ID="img" runat="server" Width="50px" Height="50px" ImageUrl='<%#ImageHelper.ResolveURL(Eval("ImagePath").ToString()) %>' />
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:DataList>
                  
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
