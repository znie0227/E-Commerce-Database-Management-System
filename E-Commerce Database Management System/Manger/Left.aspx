﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Manger_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Menu12_MenuItemClick(object sender, MenuEventArgs e)
    {
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
	<HEAD>
		<title>Function Directory</title>
		<style type="text/css">
	body  { background:#7F9ED9; margin:0px; font:normal 12px ; scrollbar-face-color: #799AE1; scrollbar-highlight-color: #799AE1; scrollbar-shadow-color: #799AE1; scrollbar-darkshadow-color: #799AE1; scrollbar-3dlight-color: #799AE1; scrollbar-arrow-color: #FFFFFF;scrollbar-track-color: #AABFEC;}
	table  { border:0px; }
	td  { font-size:12px ; }
	img  { vertical-align:bottom; border:0px; }
	a  { font-size: 12px ; color:#215DC6; text-decoration:none; }
	a:hover  { color:#428EFF }
	.sec_menu  { border-left:1px solid white; border-right:1px solid white; border-bottom:1px solid white; background:#E2ECFD; padding:5px 2px;}
	.menu_title  { }
	.menu_title span  { position:relative; top:2px; left:8px; color:#215DC6; font-weight:bold; }
	.menu_title2  { }
	.menu_title2 span  { position:relative; top:2px; left:8px; color:#428EFF; font-weight:bold; }
	</style>
	</HEAD>
	<body>
<script language="javascript" type="text/javascript">
<!--
function menuChange(obj,menu)
{
	if(menu.style.display=="")
	{
		obj.background="../Images/admin_title_bg_hide.gif";
		menu.style.display="none";
	}else{
		obj.background="../Images/admin_title_bg_show.gif";
		menu.style.display="";
	}
}

function proLoadimg()
{
	var i=new Image;
	i.src='../Images/admin_title_bg_hide.gif';
	i.src='../Images/admin_title_bg_show.gif';
}
function hideMenu(menu)
{
	menu.style.display="none";

}
proLoadimg();
-->
		</script>
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr>
				<td style="background:url('../Images/admin_title_bg_quit.gif')"  height="25">&nbsp; &nbsp;<A href="main.aspx" target="right"><strong>Manage Main</strong></A>&nbsp;
					<A href="../User/index.aspx" target="_top"><strong>Exit</strong></A>
				</td>
			</tr>
		</table>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif'); width: 154px;" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu1);">
				<span>Order Information</span>
				</td>
			</tr>
			<tr>
				<td style="width: 154px">
					<div class="sec_menu" id="menu1" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center" border="0">
							
							<tr>
								<td height="20"><A href="OrderList.aspx?OrderList=00" target="right">Not Confirmed</A> | <A href="OrderList.aspx?OrderList=01" target="right">
										Confirmed</A>
								</td>
							</tr>
							<tr>
								<td style="height: 20px"><A href="OrderList.aspx?OrderList=10" target="right">Not Paid</A> | <A href="OrderList.aspx?OrderList=11" target="right">
										Paid</A>
								</td>
							</tr>
							<tr>
								<td height="20"><A href="OrderList.aspx?OrderList=20" target="right">Not Shipped</A> | <A href="OrderList.aspx?OrderList=21" target="right">
										Shipped</A>
								</td>
							</tr>
							<tr>
								<td height="20"><A href="OrderList.aspx?OrderList=30" target="right">Not Documented</A> | <A href="OrderList.aspx?OrderList=31" target="right">
										Documented</A>
								</td>
							</tr>
							
						
						</table>
					</div>
				</td>
			</tr>
		</table>
      
		<script>hideMenu(menu1);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="cursor: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif'); width: 165px;" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu2);">
				<span>Product Information</span>
				</td>
			</tr>
			<tr>
				<td style="width: 165px">
					<div class="sec_menu" id="menu2" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center" border="0">
							
							<tr>
								<td height="20"><A href="ProductAdd.aspx" target="right">Add Product</A>| <A href="Product.aspx" target="right">
										Manage</A>
								</td>
							</tr>
							
							<tr>
								<td height="20"><A href="CategoryAdd.aspx" target="right">Add Category</A>| <A href="Category.aspx" target="right">
										Manage</A>
								</td>
							</tr>
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu2);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu3);">
				<span>Member Information</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu3" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							
							<tr>
								<td height="20"><A href="MemberAdd.aspx" target="right">Add Admin</A>| <A href="Member.aspx" target="right">
										Manage</A></td>
							</tr>
							
							<tr>
								<td height="20"><A href="Manager.aspx" target="right">Manage Member</A></td>
							</tr>
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu3);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu4);">
				<span>Shipping System</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu4" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							
							<tr>
								<td height="20"><A href="Payment.aspx?Action=Add" target="right">Add Payment</A> | <A href="Payment.aspx?Action=Manage" target="right">
										Manage</A></td>
							</tr>
							
							<tr>
								<td height="20"><A href="Shipping.aspx?Action=Add" target="right">Add shipping</A> | <A href="Shipping.aspx?Action=Manage" target="right">
										Manage</A></td>
							</tr>
							<tr>
								<td height="20"><A href="ShipArea.aspx?Action=Add" target="right">Add shiparea</A> | <A href="ShipArea.aspx?Action=Manage" target="right">
										Manage</A></td>
							</tr>
							
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu4);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu5);">
				<span>System Management</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu5" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<%--<tr>
								<td height="20"><A href="SystemBackup.aspx" target="right">
										back</A></td>
							</tr>--%>
							
							<tr>
								<td height="20"><A href="imagery.aspx" target="right">Upload Manage</A></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu5);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu6);">
				<span>Copy Right</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu6" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td height="20">George Washington University Xiaoyu He, Zhuoyi Nie, Liang Qiao, Xixi Ai, Xixi Gu</td>
							</tr>
							<tr>
								
</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<br>
		<br>
	</body>
</HTML>
