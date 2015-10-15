<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MHelp.ascx.cs" Inherits="UserControl_MHelp" %>
<table  style ="width :780px; height :41px; font-size: 9pt; text-align: center;" cellpadding="0" cellspacing="0" background ="../Images/index/BackEndEntry.jpg">
    <tr>
        <td  >
        <A href="Help.aspx?TextName=jkfs" style="font-size: 9pt;text-decoration:none; color: black;">Payment Method</A>┊<A href="Help.aspx?TextName=thhyz"  style="font-size: 9pt;text-decoration:none; color: black;">Return or Replace Rules</A>┊<A href="Help.aspx?TextName=psfw"  style="font-size: 9pt;text-decoration:none;color: black;">Shipping Range</A>┊<A href="Help.aspx?TextName=jytk"  style="font-size: 9pt;text-decoration:none; color: black;">Transaction Rules</A>┊<A href="Help.aspx?TextName=bmxy"  style="font-size: 9pt;text-decoration:none; color: black;">Non-Disclosure Agreement</A>┊<asp:LinkButton ID="lbtnALogin" runat="server" 
        OnClick="lbtnALogin_Click" Font-Size="9pt" Font-Underline="False" ForeColor="Black" CausesValidation="False">Web End Entry</asp:LinkButton>
            </td>
    </tr>
</table>
