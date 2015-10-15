<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register"  MasterPageFile="~/MasterPage/MasterPage.master" Title ="Register"%>
<asp:Content ID =Content1 ContentPlaceHolderID =FartherMain runat =server >
			
              <table  id="tabAddUserInfo" cellSpacing="1" cellPadding="1" width="540" align="center"
				border="0" runat =server>
				<tr>
					<td>
						<table class="tableBorder" id="tabAddMenber" cellSpacing="0" cellPadding="0" width="95%" align="center"
							border="0" runat =server >
							<tr>
					             <td class="tableHeaderText" align="left" height="25" colspan="2">
                                    
						            Add Member</td>
				           </tr>
							<tr>
								<td align="right" style="width: 149px">User Name:
								</td>
								<td align="left"><asp:textbox id="txtName" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*<asp:RequiredFieldValidator
                                        ID="rfvLoginName" runat="server" ControlToValidate="txtName" Font-Size="9pt"
                                        Height="1px" Width="117px">User Name can not be null!</asp:RequiredFieldValidator></FONT></td>
							</tr>
							<tr>
								<td align="right" style="height: 24px; width: 149px;">Password:
								</td>
								<td style="height: 24px" align="left"><asp:textbox id="txtPassword" runat="server"  MaxLength="50" TextMode="Password" Width="148px"></asp:textbox><FONT color="red">*<asp:RequiredFieldValidator
                                        ID="rfvPassword" runat="server" ControlToValidate="txtPassword" Font-Size="9pt"
                                        Height="1px" Width="117px">Password can not be null!</asp:RequiredFieldValidator></FONT></td>
							</tr>
							
							<tr>
								<td align="right" style="width: 149px">Gender:</td>
								<td align="left"><asp:dropdownlist id="ddlSex" runat="server">
                                    <asp:ListItem Selected="True" Value="1">Male</asp:ListItem>
                                    <asp:ListItem Value="0">Female</asp:ListItem>
                                </asp:dropdownlist></td>
							</tr>
							<tr>
								<td align="right" style="width: 149px">
                                    Real Name:
								</td>
								<td align="left"><asp:textbox id="txtTrueName" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*<asp:RequiredFieldValidator
                                        ID="rfvTrueName" runat="server" ControlToValidate="txtName" Font-Size="9pt"
                                        Height="1px" Width="117px">Real Name can not be null!</asp:RequiredFieldValidator></FONT></td>
							</tr>
							<tr>
								<td align="right" style="width: 149px">
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
								<td align="right" style="width: 149px">
                                    Address:
								</td>
								<td  valign =middle align="left"  ><asp:textbox id="txtAddress" runat="server"  MaxLength="100" Height="115px" Width="206px" TextMode="MultiLine"></asp:textbox><span
                                        style="color: #ff0000">*<asp:RequiredFieldValidator ID="rfvAddress"
                                            runat="server" ControlToValidate="txtName" Font-Size="9pt" Height="1px" Width="117px">The Address can not be null!</asp:RequiredFieldValidator></span></td>
							</tr>
							<tr>
								<td align="right" style="width: 149px">
                                    ZipCode:
								</td>
								<td align="left"><asp:textbox id="txtPostCode" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="revPostCode" runat="server" ControlToValidate="txtPostCode" Font-Size="9pt"
                                        ValidationExpression="\d{5}-?(\d{4})?$" Width="134px">Your ZipCode is Wrong!</asp:RegularExpressionValidator></FONT></td>
							</tr>
							<tr>
								<td align="right" style="width: 149px">
                                    Mobile Phone:
								</td>
								<td align =left > <asp:textbox id="txtPhone" runat="server"  MaxLength="50"></asp:textbox><FONT color="red">*<asp:RegularExpressionValidator
                                        ID="revPhone" runat="server" ControlToValidate="txtPhone"
                                        Display="Dynamic" ErrorMessage="Your Phone number is Wrong!" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator></FONT></td>
							</tr>
                            <tr>
                                <td align="right" style="height: 24px; width: 149px;">
                                    e-mail：</td>
                                <td style="height: 24px" align="left">
                                    <asp:textbox id="txtEmail" runat="server"  MaxLength="80"></asp:textbox><FONT color="red">*</FONT>
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                                        Font-Size="9pt" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        Width="132px">Your Email Address is worng!
                                    </asp:RegularExpressionValidator></td>
                            </tr>
                            
							<tr>
								<td align="center" colSpan="2"><br>
									<asp:button id="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></asp:button></td>
							</tr>
							
							</table>
							
					</td>
				</tr>
				
			</table>
			

   </asp:Content>

