<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Manger_Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Product</title>
</head>
<body style ="font-family :'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
            <table cellSpacing="0" cellPadding="0" width="640" align="center" border="0">
				<tr>
					<th class="tableHeaderText" height="25" align="left">
						&nbsp;&nbsp; Product Manage</th>
					
				<tr>
				</tr>
			</table>
			 <table cellSpacing="0" cellPadding="0" width="640" align="center" border="0">
			 <tr>
					
					<td align="center">Search:&nbsp;
						 <asp:TextBox ID="txtKey" runat="server"></asp:TextBox>&nbsp;
						<asp:Button id="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    </td>
				</tr>
          
            <tr>
                <td >
                    <br />
                    <asp:GridView ID="gvGoodsInfo" runat="server" CellPadding="4" Width="100%" HorizontalAlign="Center" DataKeyNames ="GoodsID"
							HeaderStyle-CssClass="summary-title" AutoGenerateColumns="False" OnPageIndexChanging="gvGoodsInfo_PageIndexChanging" OnRowDeleting="gvGoodsInfo_RowDeleting" AllowPaging="True" PageSize="5" >
                       <HeaderStyle Font-Bold="True" CssClass="summary-title"></HeaderStyle>
                        <Columns>
                            <asp:BoundField DataField="GoodsID" HeaderText="Product Id"  >
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="GoodsName" HeaderText="Name">
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText ="Category">
                            <HeaderStyle HorizontalAlign =Center />
                            <ItemStyle HorizontalAlign =Center />
                            <ItemTemplate >
                            <%# GetClass(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "ClassID").ToString())) %>
                            </ItemTemplate>
                            </asp:TemplateField> 
                             <asp:TemplateField HeaderText ="Member Price">
                            <HeaderStyle HorizontalAlign =Center />
                            <ItemStyle HorizontalAlign =Center />
                            <ItemTemplate >
                            $<%# GetVarStr(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString())%>
                            </ItemTemplate>
                            </asp:TemplateField> 
                          
                            <asp:HyperLinkField HeaderText="Details" Text="Details" DataNavigateUrlFields="GoodsID" DataNavigateUrlFormatString="EditProduct.aspx?GoodsID={0}" >
                                <ControlStyle Font-Underline="False" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" DeleteText="Delete" >
                                <ControlStyle Font-Underline="False" ForeColor="Black" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:CommandField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>				
    </div>
    </form>
</body>
</html>
