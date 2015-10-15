<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="ClassGoods.aspx.cs" Inherits="User_ClassGoods" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
<table style=" font-size: 9pt; font-family: Times New Roman;"  >
        <tr>
            <td align="left"  style ="width :560px; height :19px;"  background ="../Images/index/NameBlank.JPG" >
                &nbsp;&nbsp; &nbsp;<asp:Label ID="lbClassName" runat="server" Text="Label" Font-Names="Times New Roman" Font-Bold="True" ></asp:Label></td>
        </tr>
        <tr>
            <td align="left" style ="width :560px; " background="../Images/index/Product---bottom.jpg" >
                <asp:DataList ID="DLClass" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" DataKeyField ="GoodsID" OnItemCommand="DLClass_ItemCommand">
                    <ItemTemplate>
                        <table align="left"  cellpadding=0 cellspacing=0 style =" width :135px; height:158px;" >
                            <tr align =center  style =" width :135px; height:65px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" >
                                    <asp:Image ID="imageRefine" runat="server"  ImageUrl =<%#DataBinder.Eval(Container.DataItem,"GoodsUrl")%>/></td>
                            </tr>
                            <tr align=center     valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" align="center">
                                <%#DataBinder.Eval(Container.DataItem, "GoodsName")%>
                                </td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Market Price</td>
                                <td align="left" >
                                    $<%#GetVarMKP(DataBinder.Eval(Container.DataItem, "MarketPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Member Price</td>
                                <td align="left" >
                                    $<%#GetVarMBP(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" align="left">
                                    &nbsp; &nbsp;
                                    <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="detailSee" >Details</asp:LinkButton>
                                    <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandName="buyGoods"  CommandArgument='<%#DataBinder.Eval(Container.DataItem,"GoodsWeight")+"|"+DataBinder.Eval(Container.DataItem,"MemberPrice") %>' >Buy</asp:LinkButton></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
    </table>
</asp:Content>

