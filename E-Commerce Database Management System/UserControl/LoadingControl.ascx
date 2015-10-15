<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoadingControl.ascx.cs" Inherits="LoadingControl" %>        
<style type="text/css">
    .auto-style1
    {
        height: 24px;
    }
    .auto-style2
    {
        height: 28px;
    }
    .auto-style3
    {
        height: 18px;
    }
</style>
<table style="background-image: url(../Images/index/Login.jpg); width: 220px; height: 117px" border="0" cellpadding="0" cellspacing="0" runat =server   id=tabLoading >
    <tr>
        <td align="center" valign="top" style="height: 117px; width: 220px;" >
              <table style ="width: 207px; height: 90px; font-size: 9pt; font-family: 'Times New Roman';"   >
                <tr style ="width: 152px;font-size: 9pt; font-family:'Times New Roman';">
                    <td class="auto-style3">
                         Member Name</td>
                    <td class="auto-style3" style="text-align:left">
                        <asp:TextBox ID="txtName" runat="server" Height="12px" Width="70px"></asp:TextBox></td>
                  
                </tr>
                <tr style ="width: 152px;height: 18px;font-size: 9pt; font-family: 'Times New Roman';">
                    <td>
                        Password</td>
                    <td style="width: 158px;text-align:left" >
                        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password" Height="12px" Width="70px"></asp:TextBox></td>
                   
                </tr>
                <tr style ="width: 152px;height: 18px;font-size: 9pt; font-family:'Times New Roman';">
                    <td style="width: 1785px; height: 18px;" >
                        &nbsp; Verify Code</td>
                    <td style="width: 158px">
                        <asp:TextBox ID="txtValid" runat="server" Height="12px" Width="41px" style="margin-left:0px"></asp:TextBox>
                        <asp:Label ID="lbValid" runat="server" Text="8888" BackColor="Silver" Font-Names="Times New Roman" ></asp:Label></td>
                  
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp; &nbsp; &nbsp;
                        <asp:Button ID="btnLoad" runat="server" Text="Login" OnClick="btnLoad_Click" Height="25px" Width="64px" CausesValidation="False" />&nbsp; <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" Height="25px" Width="64px" CausesValidation="False" /></td>
                </tr>
            </table>  
        </td>
    </tr>
</table>
  <table  style="background-image: url(../Images/index/Login.jpg); width: 220px; height: 117px; font-size: 9pt; font-family: 'Times New Roman';"   runat =server id=tabLoad visible =false border="0" cellpadding="0" cellspacing="0"  >
                <tr>
                          <td align="center" valign="top" style="height: 117px; width: 220px;" >
                             <br /><br /><table style ="width: 178px; height: 50px; font-size: 9pt; font-family: 'Times New Roman';"   >
                <tr>
                    <td colspan="2" class="auto-style1"  >
                        &nbsp; 
                        Welcome&nbsp;<u><%=Session["UserName"]%></u>!</td>
                </tr> 
                <tr>
                    <td colspan="2" class="auto-style2" >
                        
                        <asp:HyperLink ID="hpLinkUser" runat="server" NavigateUrl="~/User/UpdateMember.aspx">Update Infor</asp:HyperLink>
                        &nbsp;&nbsp;
                        <asp:HyperLink ID="hpLinkAddAP" runat="server" NavigateUrl="~/User/AddAdvancePay.aspx">Add Value</asp:HyperLink></td>
                </tr>
            </table></td></tr></table>


      
           
             