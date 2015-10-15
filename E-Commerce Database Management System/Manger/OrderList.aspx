<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="Manger_OrderList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Order List</title>
</head>
<body  style ="font-family :'Times New Roman'; font-size :9pt;">
    <form id="form1" runat="server">
    <div>
    <table cellSpacing="0" cellPadding="0" width="100%" align="center"
				border="0">
				<tr>
					<th  align="left" height="25">
						&nbsp;&nbsp; Order Information<asp:Label id="lblTitleInfo" runat="server"></asp:Label></th>
					
				</table>
			<table  cellSpacing="0" cellPadding="0" width="100%" align="center"
				border="0">
				<tr>
					<td align="center">
						<table cellSpacing="0" cellPadding="0" width="95%" align="center">
							<tr>
								<td align="right">Key Words:</td>
								<td><asp:dropdownlist id="ddlKeyType" Runat="server">
										<asp:ListItem Selected="True" Value="OrderID">Order Id</asp:ListItem>
										<asp:ListItem Value="MemberID">Member Id</asp:ListItem>
									</asp:dropdownlist>&nbsp;&nbsp; <asp:textbox id="txtKeyword" runat="server"></asp:textbox>
                                    <asp:RegularExpressionValidator ID="revInt" runat="server" ControlToValidate="txtKeyword"
                                        ErrorMessage="Please input integer" ValidationExpression="[0-9]*$"></asp:RegularExpressionValidator></td>
							</tr>
							<tr>
								<td align="right">Order State：</td>
								<td><asp:dropdownlist id="ddlConfirmed" Runat="server">
										<asp:ListItem Selected="True" Value="All">Is Confirmed</asp:ListItem>
										<asp:ListItem Value="1">Confirmed</asp:ListItem>
										<asp:ListItem Value="0">Not Confirmed</asp:ListItem>
									</asp:dropdownlist>&nbsp;&nbsp; <asp:dropdownlist id="ddlPayed" Runat="server">
										<asp:ListItem Selected="True" Value="All">Is Paid</asp:ListItem>
										<asp:ListItem Value="2">Paid</asp:ListItem>
										<asp:ListItem Value="0">Not Paid</asp:ListItem>
									</asp:dropdownlist>&nbsp;&nbsp; <asp:dropdownlist id="ddlShipped" Runat="server">
										<asp:ListItem Selected="True" Value="All">Is Shipped</asp:ListItem>
										<asp:ListItem Value="2">Shipped</asp:ListItem>
										<asp:ListItem Value="0">Not Shipped</asp:ListItem>
									</asp:dropdownlist>&nbsp;&nbsp; <asp:dropdownlist id="ddlFinished" Runat="server">
										<asp:ListItem Selected="True" Value="All">Is Documented</asp:ListItem>
										<asp:ListItem Value="1">Documented</asp:ListItem>
										<asp:ListItem Value="0">Not Documented</asp:ListItem>
									</asp:dropdownlist></td>
							</tr>
							
							<tr>
								<td align="right"></td>
								<td>
                                    &nbsp;<asp:button id="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:button></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="height: 23px">
				
                        <asp:GridView ID="gvOrderList" runat="server"   HorizontalAlign =Center  Width =100% DataKeyNames ="OrderID" AutoGenerateColumns =False PageSize="5" AllowPaging="True" OnPageIndexChanging="gvOrderList_PageIndexChanging" OnRowDeleting="gvOrderList_RowDeleting">
                        <HeaderStyle Font-Bold =True />
                        <Columns >
                        <asp:TemplateField  HeaderText ="Order Id">
                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
									<ItemTemplate>
										<%# DataBinder.Eval(Container.DataItem, "OrderID") %>
									</ItemTemplate>                                
                        </asp:TemplateField>
                        <asp:BoundField  DataField ="OrderDate" HeaderText ="Order Date" DataFormatString ="{0:yyyy-MM-dd HH:mm}">
                        <ItemStyle  HorizontalAlign="Center" />
                        </asp:BoundField>
                         <asp:TemplateField HeaderText="Goods Fee">
                                   <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left" ></ItemStyle>
									<ItemTemplate>
										<%#GetVarGF(DataBinder.Eval(Container.DataItem, "GoodsFee").ToString()) %>
									</ItemTemplate>                              
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Ship Fee">
                                  <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetVarSF(DataBinder.Eval(Container.DataItem, "ShipFee").ToString()) %>
									</ItemTemplate>                             
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Total Price">
                                  <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetVarTP(DataBinder.Eval(Container.DataItem, "TotalPrice").ToString()) %>
									</ItemTemplate>                         
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ship Type">
                                 <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetShipName(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "ShipType").ToString())) %>
									</ItemTemplate>                       
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Pay Type">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetPayName(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "PayType").ToString())) %>
									</ItemTemplate>                     
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Member ID">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# DataBinder.Eval(Container.DataItem, "MemberID") %>
									</ItemTemplate>                    
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Member Name">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetMemberName(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "MemberID").ToString())) %>
									</ItemTemplate>                    
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Receiver Name">
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# DataBinder.Eval(Container.DataItem, "ReceiverName") %>
									</ItemTemplate>                 
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Receiver Phone">
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# DataBinder.Eval(Container.DataItem, "ReceiverPhone") %>
									</ItemTemplate>                 
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Order State">
                              <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<%# GetStatus(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "OrderID").ToString()))%>
									</ItemTemplate>                
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="">
                             <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" ></ItemStyle>
									<ItemTemplate>
										<a href='OrderModify.aspx?OrderID=<%# DataBinder.Eval(Container.DataItem, "OrderID") %>'>
											Manage</a>
									</ItemTemplate>            
                        </asp:TemplateField>
                            <asp:CommandField ShowDeleteButton="True" DeleteText="Delete"  />
                        
                        </Columns>
                        </asp:GridView>
						
								
					
								<%--<asp:ButtonColumn Text="&lt;div id=&quot;de&quot; onclick=&quot;javascript:return confirm('Confirm for deleting？')&quot;&gt;Delete&lt;/div&gt;"
									CommandName="Delete">
									<ItemStyle HorizontalAlign="Center" Width="30px"></ItemStyle>
								</asp:ButtonColumn>
							</Columns>
							<PagerStyle Mode="NumericPages"></PagerStyle>
						</asp:datagrid>--%>
						
					</td>
				</tr>
			</table>

    </div>
    </form>
</body>
</html>
