<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShipFeeInfo.aspx.cs" Inherits="User_ShipFeeInfo" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Shipping Fee</title>
</head>
<body style ="font-family :Times New Roman; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
    <table  cellSpacing="0" cellPadding="0" width="600" align="center" border="0">
				<tr>
					<th height="25" align="left">
						
						Shipping Fee(M dollars/Miles/kg)</th>
					
				<tr>
				</tr>
			</table>
			<table cellSpacing="0" cellPadding="0" width="600" align="center" border="0">
				<tr>
					<td height="23" >
                      <asp:GridView ID="gvShip" runat="server" AllowPaging =true  AutoGenerateColumns =false DataKeyNames ="ShipID" Width =100% HeaderStyle-HorizontalAlign =center HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvShip_PageIndexChanging" >
                            <Columns>
                                <asp:BoundField DataField="ShipID" HeaderText="Shipping ID" HeaderStyle-HorizontalAlign =left ItemStyle-HorizontalAlign=left ItemStyle-Width =30px/>
                                <asp:BoundField DataField="ShipWay" HeaderText="Shipping Name" HeaderStyle-HorizontalAlign =center ItemStyle-HorizontalAlign=center ItemStyle-Width =100px/>
                                
                                 <asp:TemplateField HeaderText="Shipping Item Type">
                                  <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
									<ItemTemplate>
										<%# GetClass(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "ClassID").ToString()))%>
									</ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Shipping Default Fee">
                                  <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" Width="100px"></ItemStyle>
									<ItemTemplate>
										$<%# GetVarStr(DataBinder.Eval(Container.DataItem, "ShipFee").ToString())%>
									</ItemTemplate>
                                </asp:TemplateField>
                               
                               
                            </Columns>
                        </asp:GridView>
                        <asp:Button ID="btnExit" runat="server" Text="Close" OnClick="btnExit_Click" /></td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
