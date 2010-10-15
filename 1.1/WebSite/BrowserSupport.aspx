<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BrowserSupport.aspx.cs" Inherits="BrowserSupport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="contentbox">
            <div class="whitecont" style="width:500px">
                <h1 class="title">
                    Web Browsers</h1>
                <div>
                    <div>
                        <div class="title">
                            <h1>
                                Recommended browsers</h1>
                        </div>
                        <div>
                            For best experience, use one of these browsers (click to download):</div>
                        <div>
                            <div>
                                <div class="fl">
                                    <a target="_blank" href="http://www.mozilla.com/en-US/">
                                        <img  runat="server" id="mz" />
                                    </a>
                                    <br />
                                    <div class="btitle">
                                        Mozilla Firefox 3.x +</div>
                                </div>
                                <div class="fl">
                                    <a target="_blank" href="http://www.google.com/chrome">
                                        <img runat="server" id="ch"/>
                                    </a>
                                    <br />
                                    <div class="btitle">
                                        Google Chrome 2.x +
                                    </div>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div>
                                <h1>
                                    Other supported web browsers</h1>
                            </div>
                        </div>
                        <div>
                            <div class="fl">
                                <a target="_blank" href="http://www.opera.com/download/">
                                    <img  id="op" runat="server"/>
                                </a>
                                <br />
                                <div class="btitle">
                                    Opera
                                </div>
                            </div>
                            <div class="fl">
                                <a target="_blank" href="http://www.apple.com/safari/download/">
                                    <img  id="sf" runat="server" />
                                </a>
                                <br />
                                <div class="btitle">
                                    Safari 4.x +
                                </div>
                            </div>
                            <div class="fl">
                                <a target="_blank" href="http://www.microsoft.com/windows/Internet-explorer/default.aspx">
                                    <img  id="ie" runat="server" />
                                </a>
                                <br />
                                <div class="btitle">
                                    Internet Explorer 7.x+
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
