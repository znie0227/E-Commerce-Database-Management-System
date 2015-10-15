<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="GoodsDetail.aspx.cs" Inherits="User_GoodsDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
    <table  cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr>
					<th  align="left" height="25" colspan="2">
						&nbsp;&nbsp;
						<asp:label id="lblTitleInfo" Runat="server">Goods Details</asp:label>
					</th>
				</table>
			<table  cellSpacing="1" cellPadding="1" width="480" align="center" border="0">
				<tr>
					<td>
						<table class="tableBorder" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr>
								<td align="left" style="width: 93px">Name:</td>
								
								<td style="width: 359px" align =left >&nbsp; <asp:textbox id="txtName" runat="server" ReadOnly="True"></asp:textbox></td>
								
								
							</tr>
							<tr>
								<td align="left" style="width: 93px">
                                    Category:
								</td>
								<td style="width: 359px" align="left">
                                    &nbsp;
                                    <asp:TextBox ID="txtFName" runat="server" ReadOnly="True"></asp:TextBox></td>
							</tr>

							<tr>
								<td align="left" style="height: 24px; width: 93px;">Brand:
								</td>
								<td style="width: 359px; height: 24px;" align="left">&nbsp; <asp:textbox id="txtBrand" runat="server" ReadOnly="True"></asp:textbox><span style="color: #ff0000"></span></td>
							</tr>
							
						<tr>
								<td align="left" style="width: 93px" >Unit:
								</td>
								<td style="width: 359px" align="left"> &nbsp; <asp:textbox id="txtUnit" runat="server" ReadOnly="True"></asp:textbox></td>
							</tr>
							<tr>
								<td align="left" height="17" style="width: 93px">
                                    Weight:
								</td>
								<td height="17" style="width: 359px" align="left"> &nbsp; <asp:textbox id="txtWeight" runat="server" ReadOnly="True">0</asp:textbox>kg</td>
							</tr>
							<tr>
								<td align="left" height="19" style="width: 93px">Market Price:
								</td>
								<td colSpan="3" height="19" align="left" style="width: 371px">$ <asp:textbox id="txtMarketPrice" runat="server" ReadOnly="True">0</asp:textbox></td>
							</tr>
							<tr>
								<td align="left" style="width: 93px">Member Price:
								</td>
								<td colSpan="3" align="left" style="width: 371px">$ <asp:textbox id="txtMemberPrice" runat="server" ReadOnly="True">0</asp:textbox></td>
							</tr>
							<tr>
								<td align="left" colspan="4" style="height: 15px"><b>Attatchment</b></td>
							</tr>
							<tr>
								<td align="left" style="height: 22px; width: 93px;">
                                    Image:
								</td>
								<td colSpan="3" style="height: 22px; width: 371px;" align="left">
                                    <asp:ImageMap ID="ImageMapPhoto" runat="server">
                                    </asp:ImageMap></td>
							</tr>
							<tr>
								<td align="left" style="height: 20px; width: 93px;">Is Recommended?
								</td>
								<td colSpan="3" style="height: 20px; width: 371px;" align="left"><asp:checkbox id="cbxCommend" runat="server" Checked="True" AutoPostBack="True" Enabled="False"></asp:checkbox></td>
							</tr>
							
							<tr>
								<td align="left" style="width: 93px">Is Hot?
								</td>
								<td colSpan="3" align="left" style="width: 371px"><asp:checkbox id="cbxHot" runat="server" Checked="True" AutoPostBack="True" Enabled="False"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left" style="width: 93px">Is Discount>
								</td>
								<td colSpan="3" align="left" style="width: 371px"><asp:checkbox id="cbxDiscount" runat="server" Checked="True" AutoPostBack="True" Enabled="False"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left" style="width: 93px">Description:
								</td>
								<td style="width: 359px" align="left"><asp:textbox id="txtShortDesc" runat="server" Width="307px" Height="89px" ReadOnly="True"></asp:textbox></td>
							</tr>
							<tr>
								<td align="center" colSpan="4"><br>
									<asp:button id="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" ></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
</asp:Content>

