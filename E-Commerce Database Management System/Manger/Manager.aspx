<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manager.aspx.cs" Inherits="Manger_Manager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Manager</title>
</head>
<body style ="font-family:'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
     <table class="tableBorder" cellSpacing="0" cellPadding="0" width="650" align="center" border="0">
				<tr>
					<th class="tableHeaderText" height="25" align="left">
                        Manage Member</th>
					
				<tr>
				</tr>
			</table>
			<table class="tableBorder" cellSpacing="0" cellPadding="0" width="650" align="center" border="0">
				<tr>
					<td height="23" >
                       <asp:GridView ID="gvMemberList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="5" DataKeyNames ="MemberID"  Width="100%" HorizontalAlign="Center"
							HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvMemberList_PageIndexChanging" OnRowDeleting="gvMemberList_RowDeleting">
							<HeaderStyle Font-Bold="True" CssClass="summary-title"></HeaderStyle>
                            <Columns>
                                <asp:BoundField DataField="MemberID" HeaderText="Member Id" ReadOnly="True" >
                                    <ItemStyle HorizontalAlign="Left" Width="40px" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="TrueName" HeaderText="Real Name" >
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Phonecode" HeaderText="Cell Phone" >
                                    <ItemStyle HorizontalAlign="Left"  />
                                    <HeaderStyle HorizontalAlign="center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Emails" HeaderText="Email" />
                                <asp:BoundField DataField="City" HeaderText="City" />  
                                <asp:TemplateField  HeaderText ="Address">
                                <HeaderStyle HorizontalAlign =center />
                                <ItemStyle HorizontalAlign =left />
                                <ItemTemplate>    
                                <%#DataBinder.Eval(Container.DataItem,"Address")%>
                                </ItemTemplate> 
                                </asp:TemplateField>
                                <asp:BoundField DataField="PostCode" HeaderText="Zip Code" />
                                <asp:BoundField DataField="AdvancePayment" HeaderText="Advance Value" />
                                <asp:TemplateField  HeaderText="Join Date">
                                <HeaderStyle HorizontalAlign =center />
                                <ItemStyle HorizontalAlign =left />
                                <ItemTemplate>
                                <%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "LoadDate").ToString()).ToLongDateString()%>
                                </ItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowDeleteButton="True" DeleteText="Delete" />
                            </Columns>
                        </asp:GridView>
					</td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
