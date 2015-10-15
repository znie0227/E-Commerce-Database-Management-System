<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="User_CheckOut" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
<table  cellSpacing="0" cellPadding="0" width="480" align="center" border="0">
				<tr style =" font :9pt; font-family :'Times New Roman';">
					<th  align="left" height="25px" colspan="2px">
						&nbsp;&nbsp;
						<asp:label id="lblTitleInfo" Runat="server">Please input shipping information</asp:label>
					</th>
				</table>
			<table  cellSpacing="1" cellPadding="1" width="480" align="center" border="0">
				<tr style =" font :9pt; font-family :'Times New Roman';">
					<td>
						<table class="tableBorder" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left" width="100" style="height: 28px">
                                    Name:</td>
								
								<td style="width: 359px; height: 28px;" align =left ><asp:textbox id="txtReciverName" runat="server"></asp:textbox><font color="red">*</font></td>
								
								
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left">
                                    Address:
								</td>
								<td style="width: 359px" align =left >
									<asp:textbox id="txtReceiverAddress" runat="server"></asp:textbox><font color="red">*</font></td>
							</tr>

							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left" style="height: 24px">
                                    Cell Phone:
								</td>
								<td style="width: 359px; height: 24px;"  align =left ><asp:textbox id="txtReceiverPhone" runat="server"></asp:textbox><font color="red">*<asp:RegularExpressionValidator
                                        ID="revPhone" runat="server" ControlToValidate="txtReceiverPhone" Display="Dynamic"
                                        ErrorMessage="Your cell phone number is wrong!" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator></font></td>
							</tr>
							
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left">
                                    Zip Code:
								</td>
								<td style="width: 359px" align =left ><asp:textbox id="txtReceiverPostCode" runat="server"></asp:textbox><font color="red">*<asp:RegularExpressionValidator
                                        ID="revPostCode" runat="server" ControlToValidate="txtReceiverPostCode" Font-Size="9pt"
                                        ValidationExpression="\d{5}-?(\d{4})?$" Width="134px">Your Zip Code is wrong!</asp:RegularExpressionValidator></font></td>
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left" height="17">
                                    Email:
								</td>
								<td height="17" style="width: 359px" align =left ><asp:textbox id="txtReceiverEmails" runat="server"></asp:textbox><font color="red">*<asp:RegularExpressionValidator
                                        ID="revEmail" runat="server" ControlToValidate="txtReceiverEmails" Font-Size="9pt"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Width="132px">Your Email address is Wrong!</asp:RegularExpressionValidator></font></td>
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left" height="19">
                                    City:
								</td>
								<td colSpan="3" height="19" align =left ><asp:DropDownList id="ddlShipCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlShipCity_SelectedIndexChanged">
                                </asp:DropDownList>
                                    <asp:Label ID="labKM" runat="server" Text=""></asp:Label>&nbsp;Miles</td>
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left" height="19">
                                    Shipping Type:
								</td>
								<td colSpan="3" height="19" align =left ><asp:DropDownList id="ddlShipType" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                    <asp:LinkButton ID="lnkbtnSee" runat="server" OnClick="lnkbtnSee_Click">View Shipping Fee</asp:LinkButton></td>
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="left">
                                    Payment Method:
								</td>
								<td colSpan="3" align =left ><asp:DropDownList id="ddlPayType" runat="server" AutoPostBack="True">
                                </asp:DropDownList></td>
							</tr>
							<tr style =" font :9pt; font-family :'Times New Roman';">
								<td align="center" colSpan="4"><br>
									<asp:button id="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" ></asp:button>&nbsp;&nbsp; <asp:button id="btnReset" runat="server" Text="Exit" OnClick="btnReset_Click"  ></asp:button>
                                    </td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
</asp:Content>

