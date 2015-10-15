<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProduct.aspx.cs" Inherits="Manger_EditProduct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit Product</title>
</head>
<body style ="font-family :'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
    <table  cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr>
					<th  align="left" height="25" colspan="2">
						&nbsp;&nbsp;
						<asp:label id="lblTitleInfo" Runat="server">Product Details</asp:label>
					</th>
				<tr>
				</tr>
			</table>
			<table  cellSpacing="1" cellPadding="1" width="480" align="center" border="0">
				<tr>
					<td>
						<table class="tableBorder" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr>
								<td aligName: </td>
								
								<td style="width: 359px">&nbsp;<asp:textbox id="txtName" runat="server"></asp:textbox><font color="red">*><font color="red">*</font></td>
								
								
							</tr>
							<tr>
								<td align="left">
                Category:
								</td>
								<td style="width: 359px">
									&nbsp;<asp:DropDownList id="ddlCategory" runat="server" AutoPostBack="True"></asp:DropDownList>
								</td>
							</tr>

							<tr>
								<td align="left" style="height: 24px">Brand
								</td>
								<td style="width: 359px; height: 24px;">&nbsp;<asp:textbox id="txtBrand" runat="server"></asp:textbox><span style="color: #ff0000">*e="color: #ff0000">*</span></td>
							</tr>
							
							<tr>
					Quantity:
								</td>
								<td style="width: 359px">&nbsp;<asp:textbox id="txtUnit" runat="server"></asp:textbox><FONT color="red">*><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="left" Weight:
								</td>
								<td style="width: 359px; height: 8px;">&nbsp;<asp:textbox id="txtWeight" runat="server">0</asp:textbox>kg<span style="color: #ff0000">*e="color: #ff0000">*</span></td>
							</tr>
							<tr>
								<td align="left" height="19">Market Price:
								</td>
								<td colSpan="3" height="19">$<asp:textbox id="txtMarketPrice" runat="server">0</asp:textbox><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="left">Member Price:
								</td>
								<td colSpan="3">$<asp:textbox id="txtMemberPrice" runat="server">0</asp:textbox>$<FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="left" colspan="4" style="height: 15px"><b>Attatchment</b></td>
							</tr>
							<tr>
								<td align="left">
                                    Image:
								</td>
								<td colSpan="3">
                                    <asp:DropDownList ID="ddlUrl" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="ddlUrl_SelectedIndexChanged">
                                    </asp:DropDownList></td>
							</tr>
                            <tr>
                                <td align="left" style="height: 22px">
                                </td>
                                <td colspan="3" style="height: 22px">
                                    <asp:ImageMap ID="ImageMapPhoto" runat="server">
                                    </asp:ImageMap></td>
                            </tr>
							<tr>
								<td align="left" style="height: 20px">Is Recommanded?
								</td>
								<td colSpan="3" style="height: 20px"><asp:checkbox id="cbxCommend" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							
							<tr>
								<td align="left">
                                    Is Hot?
								</td>
								<td colSpan="3"><asp:checkbox id="cbxHot" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left">Is Discount?
								</td>
								<td colSpan="3"><asp:checkbox id="cbxDiscount" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left">Description:
								</td>
								<td style="width: 359px"><asp:textbox id="txtShortDesc" runat="server" Width="307px" Height="89px"></asp:textbox></td>
							</tr>
							<tr>
								<td align="center" colSpan="4"><br>
									<asp:button id="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
