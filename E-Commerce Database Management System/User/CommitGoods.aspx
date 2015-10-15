<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="CommitGoods.aspx.cs" Inherits="User_CommitGoods" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
  <table  cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr style =" font :9pt; font-family :Times New Roman;">
					<th  align="left" height="25" colspan="2">
						&nbsp;&nbsp;
						<asp:label id="lblTitleInfo" Runat="server">Shopping Cart</asp:label>
					</th>
				</table>
			<table  cellSpacing="1" cellPadding="1" width="480" align="center" border="0">
				<tr style =" font :9pt; font-family :Times New Roman;">
					<td>
						<table cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr style =" font :9pt; font-family :Times New Roman;">
							<td align="left" style="height: 135px">
							 <asp:GridView ID="gvShopCart" AlternatingRowStyle-BorderColor="Navy" AlternatingRowStyle-BorderStyle="Solid" AlternatingRowStyle-BorderWidth="1px" DataKeyNames ="CartID" runat="server" AllowPaging="True" AutoGenerateColumns="False" PageSize="5"  OnPageIndexChanging="gvShopCart_PageIndexChanging" OnRowCancelingEdit="gvShopCart_RowCancelingEdit" OnRowDeleting="gvShopCart_RowDeleting" OnRowEditing="gvShopCart_RowEditing" OnRowUpdating="gvShopCart_RowUpdating" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                                 <Columns>
                                     <asp:BoundField DataField="GoodsName" HeaderText="Name" ReadOnly="True">
                                         <ItemStyle HorizontalAlign="Center" />
                                         <HeaderStyle HorizontalAlign="Center" />
                                     </asp:BoundField>
                                  
                                     <asp:TemplateField HeaderText ="Market Price">
                                     <HeaderStyle HorizontalAlign="Center" />
                                     <ItemStyle HorizontalAlign ="Center" />
                                     <ItemTemplate >
                                     $<%#GetMKPStr(DataBinder.Eval(Container.DataItem,"MarketPrice").ToString())%>
                                     </ItemTemplate>    
                                     </asp:TemplateField>
                                    <asp:TemplateField HeaderText ="Member Price">
                                     <HeaderStyle HorizontalAlign="Center" />
                                     <ItemStyle HorizontalAlign ="Center" />
                                     <ItemTemplate >
                                     $<%#GetMBPStr(DataBinder.Eval(Container.DataItem,"MemberPrice").ToString())%>
                                     </ItemTemplate>    
                                     </asp:TemplateField>
                                     <asp:BoundField DataField="Num" HeaderText="Quantity">
                                         <ItemStyle HorizontalAlign="Center" />
                                         <HeaderStyle HorizontalAlign="Center" />
                                     </asp:BoundField>
                                     
                                     <asp:TemplateField HeaderText ="Total">
                                     <HeaderStyle HorizontalAlign="Center" />
                                     <ItemStyle HorizontalAlign ="Center" />
                                     <ItemTemplate >
                                     $<%#GetSPStr(DataBinder.Eval(Container.DataItem, "SumPrice").ToString())%>
                                     </ItemTemplate>    
                                     </asp:TemplateField>
                                     <asp:CommandField ShowDeleteButton="True"  DeleteText="Delete"/>
                                     <asp:CommandField ShowEditButton="True" EditText="Edit" UpdateText="Update" CancelText="Cancel" />
                                 </Columns>
                                 <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                 <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF "  BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                                 <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                 <RowStyle BackColor="White" ForeColor="#003399"  BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                                 <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99"  />
                                 <SortedAscendingCellStyle BackColor="#EDF6F6"  BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                                 <SortedAscendingHeaderStyle BackColor="#0D4AC4" BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px"/>
                                 <SortedDescendingCellStyle BackColor="#D6DFDF" BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                                 <SortedDescendingHeaderStyle BackColor="#002876" BorderColor="Navy" BorderStyle="Solid" BorderWidth="1px" />
                                </asp:GridView>
							</td>
							</tr>
							<tr align =left >
							<td align="center">
                                <asp:Label ID="lbLag" runat="server" Text="Null Cart" Visible="False"></asp:Label></td>
							</tr>
							<tr align =left>
							<td style="height: 12px">
							Total: &nbsp; &nbsp;
                                $<asp:Label ID="lbSumPrice" runat="server" Text="Label"></asp:Label></td>
							</tr>
							<tr align =left>
							<td>
                                Quantity:&nbsp;&nbsp;
                                <asp:Label ID="lbSumNum" runat="server" Text="Label"></asp:Label></td>
							</tr>
							<tr>
								<td align="center" >
                                    <asp:LinkButton ID="lnkbtnClear" runat="server" OnClick="lnkbtnClear_Click">Empty Cart</asp:LinkButton>
                                    &nbsp;&nbsp;
                                    <asp:LinkButton ID="lnkbtnContinue" runat="server" OnClick="lnkbtnContinue_Click">Continue Shopping</asp:LinkButton>  
                                    &nbsp;&nbsp;  
                                    <asp:LinkButton ID="lnkbtnCheck" runat="server" OnClick="lnkbtnCheck_Click">Check Out</asp:LinkButton>
									</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
</asp:Content>

