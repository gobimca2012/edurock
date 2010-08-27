<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventInfo.aspx.cs" Inherits="User_AjaxControl_EventInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/div/xhtml1/DTD/xhtml1-transitional.dtd">
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
            <div id="divMessage" runat="server">
            </div>
            <fieldset>
                <legend>Event</legend>
                <div>
                    <div>
                        <div>
                            <span class="label">Title</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Description</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="400"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Meta Description</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtMetaDescription" runat="server" TextMode="MultiLine" Height="300"> </asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Start Date</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">End Date</span><span class="valmsg" >(Required)*</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <div>
                                <%--<span class="label">Select your Cource</span><span class="valmsg" >(Required)*</span>--%>
                                <cram:SpaceLabel ID="lblcc" runat="server" EnableViewState="false" CssClass="label"></cram:SpaceLabel><span class="valmsg" >(Required)*</span>
                            </div>
                            <div>
                                <asp:DropDownList ID="ddCource" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div>
                            <div>
                                <%--<span class="label">Select your Subject</span>--%>
                                <cram:CategoryLabel ID="asa" runat="server" EnableViewState="false" CssClass="label"></cram:CategoryLabel><span class="valmsg" >(Required)*</span>
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
                    <div>
                        <div>
                            <span class="label">Contact Person</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtContactPerson" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Contact Email</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtContactEmail" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <div>
                            <span class="label">Contact Phone</span>
                        </div>
                        <div>
                            <asp:TextBox ID="txtContactPhone" runat="server"></asp:TextBox>
                        </div>
                    </div>
                   
                </div>
            </fieldset>
        </div>
        <div class="gray">
            <div>
                <aspajax:AjaxLinkButton ID="lnkAddEvent" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="AddAjaxClick"><div class="btn editbtn"><%=Resources.Default.Add_Text%></div></aspajax:AjaxLinkButton>
            </div>
            <div>
                <aspajax:AjaxLinkButton ID="lnkUpdateEvent" runat="server" RequestContainner="#contentBox"
                    ResponseContainner="#contentBox" OnAjaxClick="UpdateAjaxClick"><div class="btn editbtn">Update</div></aspajax:AjaxLinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
