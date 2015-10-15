﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Manger_Category" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Category</title>
</head>
<body style ="font-family :'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
    <table class="tableBorder" cellSpacing="0" cellPadding="0" width="450" align="center" border="0">
				<tr>
					<th class="tableHeaderText" height="25" align="left">
						&nbsp;&nbsp; Goods Type Category</th>
					
				<tr>
				</tr>
			</table>
			<table class="tableBorder" cellSpacing="0" cellPadding="0" width="450" align="center" border="0">
				<tr>
					<td height="23" class="forumRowHighlight">
                        &nbsp;<asp:GridView ID="gvCategoryList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="5" DataKeyNames ="ClassID"  Width="100%" HorizontalAlign="Center"
							HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvCategoryList_PageIndexChanging" OnRowDeleting="gvCategoryList_RowDeleting">
							<HeaderStyle Font-Bold="True"></HeaderStyle>
                            <Columns>
                                <asp:BoundField DataField="ClassID" HeaderText="Type Id"   ItemStyle-Width="40" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                                <asp:BoundField DataField="ClassName" HeaderText="Type Name" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
                               
                                <asp:CommandField ShowDeleteButton="True" DeleteText="Delete" ItemStyle-Width="30" ItemStyle-HorizontalAlign="Center" />
                            </Columns>
                        </asp:GridView>
					</td>
				</tr>
			</table>

    </div>
    </form>
</body>
</html>
