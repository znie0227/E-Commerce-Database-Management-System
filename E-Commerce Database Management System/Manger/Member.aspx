<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Member.aspx.cs" Inherits="Manger_Member" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Member</title>
</head>
<body style ="font-family:'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
     <table class="tableBorder" cellSpacing="0" cellPadding="0" width="450" align="center" border="0">
				<tr>
					<th class="tableHeaderText" height="25" align="left">
						Manage</th>
					
				<tr>
				</tr>
			</table>
			<table class="tableBorder" cellSpacing="0" cellPadding="0" width="450" align="center" border="0">
				<tr>
					<td height="23" class="forumRowHighlight">
                        &nbsp;<asp:GridView ID="gvCategoryList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="5" DataKeyNames ="AdminID"  Width="100%" HorizontalAlign="Center"
							HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvCategoryList_PageIndexChanging" OnRowCancelingEdit="gvCategoryList_RowCancelingEdit" OnRowDeleting="gvCategoryList_RowDeleting" OnRowEditing="gvCategoryList_RowEditing" OnRowUpdating="gvCategoryList_RowUpdating">
							<HeaderStyle Font-Bold="True" CssClass="summary-title"></HeaderStyle>
                            <Columns>
                                <asp:BoundField DataField="AdminID" HeaderText="Admin Id" ReadOnly="True" >
                                    <ItemStyle HorizontalAlign="Left" Width="40px" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Admin" HeaderText="Admin Name" >
                                    <ItemStyle HorizontalAlign="Left" />
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Password" HeaderText="Admin Password"  HeaderStyle-HorizontalAlign =left ItemStyle-HorizontalAlign =left />
                                <asp:CommandField ShowDeleteButton="True" DeleteText="Delete" >
                                    <ItemStyle HorizontalAlign="Left" Width="30px" />
                                </asp:CommandField>
                                <asp:CommandField ShowEditButton="True" EditText="Edit" CancelText="Cancel" UpdateText="Update" />
                            </Columns>
                        </asp:GridView>
					</td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
