<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AddAdvancePay.aspx.cs" Inherits="User_AddAdvancePay" Title="Untitled Page" %>
<%@ Register Src="../UserControl/LoadingControl.ascx" TagName="LoadingControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
<table  id="tabAddPayment" cellSpacing="0" cellPadding="0" width="95%" align="center"
							border="0" runat =server >
							 <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                                <td align="left" style="height: 24px" width="250"   colspan =2>
                                    Add Value: </td>
                                    </tr>
                                    <tr>
                                    
                                <td align="right" style="height: 24px; width: 158px;">
                                Please Choose Bank Information
                                    </td>
                                        <td style="height: 24px" align="left">&nbsp;<asp:DropDownList ID="ddlPayWay" runat="server" Width="127px" Font-Size="9pt">
                                <asp:ListItem>Master Card</asp:ListItem>
                                <asp:ListItem>Visa Card</asp:ListItem>
                                <asp:ListItem>Discover Card</asp:ListItem>
                                <asp:ListItem>JCB</asp:ListItem>
                                <asp:ListItem>UnionPay</asp:ListItem> 
                            </asp:DropDownList></td>
                            </tr>
							 <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                                <td align="right" style="height: 24px; width: 158px;">
                                    Card Number:</td>
                                <td style="height: 24px" align="left">
                                    &nbsp;<asp:textbox id="txtCode" runat="server"  MaxLength="20"></asp:textbox><FONT color="red">*</FONT>
                                    <asp:RequiredFieldValidator ID="rfvCode" runat="server" ControlToValidate="txtCode"
                                        Display="Dynamic" ErrorMessage="Please input card number!"></asp:RequiredFieldValidator></td>
                            </tr>
                    <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                        <td align="right" style="height: 24px; width: 158px;">
                            CVV</td>
                        <td style="height: 24px" align="left">
                            &nbsp;<asp:TextBox ID="txtStatus" runat="server" MaxLength="20"></asp:TextBox><FONT color="red">*</font>
                            </td>
                    </tr>
							 <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                                <td align="right" style="height: 24px; width: 158px;">
                                    Expiration Date</td>
                                <td style="height: 24px" align="left">
                                    &nbsp;<asp:textbox id="txtCodePassword" runat="server"  MaxLength="20"></asp:textbox></td>
                            </tr>
                                         <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                                <td align="right" style="height: 24px; width: 158px;">
                                    Value</td>
                                <td style="height: 24px" align="left">
                                    $<asp:textbox id="txtAdvancePayment" runat="server"  MaxLength="20">0</asp:textbox><FONT color="red">*</FONT>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAdvancePayment"
                                        ErrorMessage="Please input correctly（Format：1.00）" ValidationExpression="^[0-9]+(.[0-9]{2})?$"></asp:RegularExpressionValidator></td>
                                        </tr>
                                        <tr style ="font-size: 9pt; font-family:'Times New Roman';">
                                        <td style="height: 24px" colspan =2 align =center >
                                            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click"  />
                                            &nbsp;&nbsp;
                                            <asp:Button ID="btnExit" runat="server" Text="Exit" CausesValidation="False" OnClick="btnExit_Click" /></td>
                            </tr>
						</table>
</asp:Content>




