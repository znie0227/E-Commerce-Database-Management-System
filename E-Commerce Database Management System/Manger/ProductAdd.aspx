<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductAdd.aspx.cs" Inherits="Manger_ProductAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add Product</title>
</head>
<body  style="font-family :'Times New Roman'; font-size: 9pt;">
<form id="Form1" method="post" runat="server">
			<table  cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr>
					<th  align="left" height="25" colspan="2">
						&nbsp;&nbsp;
						<asp:label id="lblTitleInfo" Runat="server">Add Product</asp:label>
					</th>
				</table>
			<table  cellSpacing="1" cellPadding="1" width="480" align="center" border="0" id="tabAddProduct">
				<tr>
					<td style="width: 478px">
						<table class="tableBorder" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr>
								<td align="left" width="80">Name: </td>
								
								<td style="width: 359px"><asp:textbox id="txtName" runat="server"></asp:textbox><font color="red">*</font></td>
								
								
							</tr>
							<tr>
								<td align="left">
                                    Category:
								</td>
								<td style="width: 359px">
									<asp:DropDownList id="ddlCategory" runat="server" AutoPostBack="True"></asp:DropDownList>
								</td>
							</tr>

							<tr>
								<td align="left" style="height: 24px">Brand: 
								</td>
								<td style="width: 359px; height: 24px;"><asp:textbox id="txtBrand" runat="server"></asp:textbox><span style="color: #ff0000">*</span></td>
							</tr>
							
							<tr>
								<td align="left">Quantity: 
								</td>
								<td style="width: 359px"><asp:textbox id="txtUnit" runat="server"></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="left" height="17">Weight: 
								</td>
								<td height="17" style="width: 359px"><asp:textbox id="txtWeight" runat="server">0</asp:textbox>kg<span style="color: #ff0000">*<asp:RegularExpressionValidator
                                        ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtWeight"
                                        ErrorMessage="Please input Correctly(Format：1.00）" ValidationExpression="^[0-9]+(.[0-9]{2})?$"></asp:RegularExpressionValidator></span></td>
							</tr>
							<tr>
								<td align="left" height="19">Market Price:
								</td>
								<td colSpan="3" height="19"><asp:textbox id="txtMarketPrice" runat="server">0</asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMarketPrice"
                                        ErrorMessage="Please input Correctly(Format：1.00）" ValidationExpression="^[0-9]+(.[0-9]{2})?$"></asp:RegularExpressionValidator></FONT></td>
							</tr>
							<tr>
								<td align="left">Member Price: 
								</td>
								<td colSpan="3"><asp:textbox id="txtMemberPrice" runat="server">0</asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtMemberPrice"
                                        ErrorMessage="Please Input Correctly（Format：1.00）" ValidationExpression="^[0-9]+(.[0-9]{2})?$"></asp:RegularExpressionValidator></FONT></td>
							</tr>
							<tr>
								<td align="left" colspan="4" style="height: 15px"><b>Attatchment</b></td>
							</tr>
							<tr>
								<td align="left" style="height: 22px">
                                    Image：
								</td>
								<td colSpan="3" style="height: 22px">
                                    <asp:DropDownList ID="ddlUrl" runat="server" OnSelectedIndexChanged="ddlUrl_SelectedIndexChanged" AutoPostBack="True">
                                    </asp:DropDownList></td>
							</tr>
                            <tr>
                                <td align="left" style="height: 22px">
                                </td>
                                <td colspan="3" style="height: 22px">
                                    <asp:ImageMap ID="ImageMapPhoto" runat="server" ImageUrl="~/Images/icon_7.gif">
                                    </asp:ImageMap></td>
                            </tr>
							<tr>
								<td align="left" style="height: 20px">Is Recommended：
								</td>
								<td colSpan="3" style="height: 20px"><asp:checkbox id="cbxCommend" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							
							<tr>
								<td align="left">
                                    Is Hot：
								</td>
								<td colSpan="3"><asp:checkbox id="cbxHot" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left">Is Discount：
								</td>
								<td colSpan="3"><asp:checkbox id="cbxDiscount" runat="server" Checked="True" AutoPostBack="True"></asp:checkbox></td>
							</tr>
							<tr>
								<td align="left">
                                    Description：
								</td>
								<td style="width: 359px"><asp:textbox id="txtShortDesc" runat="server" Width="307px" Height="89px" TextMode="MultiLine"></asp:textbox></td>
							</tr>
							<tr>
								<td align="center" colSpan="4"><br>
									<asp:button id="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></asp:button><asp:button id="btnReset" runat="server" Text="Reset"  OnClick="btnReset_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			
		</form>
	</body>

</html>
