<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateMember.aspx.cs" Inherits="User_UpdateMember" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
 <table  id="tabAddUserInfo" cellSpacing="1" cellPadding="1" width="560" align="center"
				border="0" runat =server>
				<tr>
					<td style="width: 540px">
						<table class="tableBorder" id="tabAddMenber" cellSpacing="0" cellPadding="0" width="95%" align="center"
							border="0" runat =server >
							<tr>
					             <td class="tableHeaderText" align="left" height="25" colspan="2">
                                     &nbsp; &nbsp;&nbsp;
                                     Update Member Information</td>
				           </tr>
							<tr>
								<td align="right" width="250">User Name:
								</td>
								<td align="left"><asp:textbox id="txtName" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="right" width="250" style="height: 24px">Password:
								</td>
								<td style="height: 24px" align="left"><asp:textbox id="txtPassword" runat="server"  MaxLength="50" ></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
						
							<tr>
								<td align="right" width="250">Gender:</td>
								<td align="left"><asp:dropdownlist id="ddlSex" runat="server">
                                    <asp:ListItem Selected="True" Value="1">Male</asp:ListItem>
                                    <asp:ListItem Value="0">Female</asp:ListItem>
                                </asp:dropdownlist></td>
							</tr>
							<tr>
								<td align="right" width="250">
                                    Real Name:
								</td>
								<td align="left"><asp:textbox id="txtTrueName" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="right" width="250">
                                    City:
								</td>
								<td align="left"><asp:DropDownList ID="ddlCity" runat="server" Width="127px" Font-Size="9pt">
                                 <asp:ListItem>Arlington</asp:ListItem>
                                <asp:ListItem>Vienna</asp:ListItem>
                                <asp:ListItem>Richmond</asp:ListItem>
                                <asp:ListItem>Alexandria</asp:ListItem>
                                <asp:ListItem>Fairfax</asp:ListItem>
                                <asp:ListItem>Falls Church</asp:ListItem>
                                <asp:ListItem>D.C.</asp:ListItem>
                                <asp:ListItem>Baltimore</asp:ListItem>
                                <asp:ListItem>Annapolis</asp:ListItem>
                                <asp:ListItem>Ocean City</asp:ListItem>
                                <asp:ListItem>New York City</asp:ListItem>
                                <asp:ListItem>Los Angeles</asp:ListItem>
                                <asp:ListItem>San Francisco</asp:ListItem>
                            </asp:DropDownList></td>
							</tr>
							<tr>
								<td align="right" width="250">
                                    Address:
								</td>
								<td  valign =middle align="left"  ><asp:textbox id="txtAddress" runat="server"  MaxLength="100" Height="115px" Width="206px" TextMode="MultiLine"></asp:textbox><span
                                        style="color: #ff0000">*</span></td>
							</tr>
							<tr>
								<td align="right" width="250">
                                    ZipCode:
								</td>
								<td align="left"><asp:textbox id="txtPostCode" runat="server"  MaxLength="50" AutoPostBack="True"></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
							<tr>
								<td align="right" width="250">
                                    Cell Phone:
								</td>
								<td align="left"><asp:textbox id="txtPhone" runat="server"  MaxLength="50" AutoPostBack="True"></asp:textbox><FONT color="red">*</FONT></td>
							</tr>
                            <tr>
                                <td align="right" style="height: 24px" width="250">
                                    e-mail：</td>
                                <td style="height: 24px" align="left">
                                    <asp:textbox id="txtEmail" runat="server"  MaxLength="80" AutoPostBack="True"></asp:textbox><FONT color="red">*</FONT>
                                    </td>
                            </tr>
                            
							<tr>
								<td align="center" colSpan="2"><br>
									<asp:button id="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ></asp:button></td>
							</tr>
							</table>
							
					</td>
				</tr>
			
			</table>
</asp:Content>





