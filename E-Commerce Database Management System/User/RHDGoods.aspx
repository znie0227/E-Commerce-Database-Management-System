<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="RHDGoods.aspx.cs" Inherits="User_RHDGoods" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FartherMain" Runat="Server">
    <table style=" font-size: 9pt; font-family: Times New Roman;" runat =server id="tabRefine"  >
        <tr>
            <td align="left" style ="width :560px; height :22px;" background ="../Images/index/Refinement.jpg">
              </td>
        </tr>
        <tr>
            <td align="left" style ="width :560px; " background="../Images/index/Product---bottom.jpg"  >
                <asp:DataList ID="DLrefinement" DataKeyField ="GoodsID" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DLrefinement_ItemCommand">
                    <ItemTemplate>
                        <table align="left" cellpadding=0 cellspacing=0 style =" width :135px; height:158px;" >
                            <tr align =center   style =" width :135px; height:65px;font-size: 9pt; font-family: Times New Roman;" >
                                <td colspan="2" >
                                    <asp:Image ID="imageRefine" runat="server"  ImageUrl =<%#DataBinder.Eval(Container.DataItem,"GoodsUrl")%>/></td>
                            </tr>
                            <tr align =center  valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" align="center">
                                <%#DataBinder.Eval(Container.DataItem, "GoodsName")%>
                                </td>
                            </tr>
                            <tr align =center   valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Market Price</td>
                                <td align="left" >
                                    $<%#GetMKPStr(DataBinder.Eval(Container.DataItem, "MarketPrice").ToString())%></td>
                            </tr>
                            <tr align =center   valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Member Price</td>
                                <td align="left" >
                                    $<%#GetMBPStr(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString())%></td>
                            </tr>
                            <tr align =center   valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2">
                                    &nbsp;&nbsp;
                                    <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="detailSee" >Details</asp:LinkButton>
                                    <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandName="buyGoods" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"GoodsWeight")+"|"+DataBinder.Eval(Container.DataItem,"MemberPrice") %>'>Buy</asp:LinkButton></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
    </table>
    <table style="font-size: 9pt; font-family: Times New Roman;" runat =server id ="tabHot"　>
        <tr>
            <td align="left" style ="width :560px; height :22px;" background ="../Images/index/Hot.jpg">
               </td>
        </tr>
        <tr>
            <td style ="width :560px; height :157px;" background ="../Images/index/RefinementBottom.jpg"  align="left">
                <asp:DataList ID="DLHot" DataKeyField ="GoodsID" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DLHot_ItemCommand">
                    <ItemTemplate>
                        <table align="left" cellpadding=0 cellspacing=0 style =" width :135px; height:158px;">
                            <tr align =center style =" width :135px; height:65px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" align="center" > <asp:Image ID="imageHot" runat="server"  ImageUrl =<%#DataBinder.Eval(Container.DataItem,"GoodsUrl")%>/>
                                </td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;" align =center>
                                <td colspan="2" align="center">
                                <%#DataBinder.Eval(Container.DataItem, "GoodsName")%>
                                </td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Market Price</td>
                                <td align="left">
                                    $<%#GetMKPStr(DataBinder.Eval(Container.DataItem, "MarketPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Member Price</td>
                                <td align="left">
                                    $<%#GetMBPStr(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2">
                                     &nbsp; &nbsp;
                                    <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="detailSee" >Details</asp:LinkButton>
                                    <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandName="buyGoods" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"GoodsWeight")+"|"+DataBinder.Eval(Container.DataItem,"MemberPrice") %>'>Buy</asp:LinkButton></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
    </table>
     <table style="font-size: 9pt; font-family: Times New Roman;" runat=server id="tabDiscount">
        <tr>
            <td align="left" style ="width :560px; height :22px;" background ="../Images/index/SaleProduct.jpg">
               </td>
        </tr>
        <tr>
            <td align="left" style ="width :560px; height :157px;" background ="../Images/index/RefinementBottom.jpg">
                <asp:DataList ID="DLDiscount" DataKeyField ="GoodsID" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DLDiscount_ItemCommand">
                    <ItemTemplate>
                        <table align="left" cellpadding=0 cellspacing=0 style =" width :135px; height:158px;">
                            <tr align =center  style =" width :135px; height:65px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2" align="center" ><asp:Image ID="imageDiscount" runat="server"  ImageUrl =<%#DataBinder.Eval(Container.DataItem,"GoodsUrl")%>/>
                                </td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;" align =center>
                                <td colspan="2">
                                <%#DataBinder.Eval(Container.DataItem, "GoodsName")%>
                                </td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Market Price</td>
                                <td align="left">
                                    $<%#GetMKPStr(DataBinder.Eval(Container.DataItem, "MarketPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td align="center">
                                    Member Price</td>
                                <td align="left">
                                    $<%#GetMBPStr(DataBinder.Eval(Container.DataItem, "MemberPrice").ToString())%></td>
                            </tr>
                            <tr valign =bottom style =" width :135px; height:11px;font-size: 9pt; font-family: Times New Roman;">
                                <td colspan="2">
                                     &nbsp; &nbsp;
                                    <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="detailSee" >Details</asp:LinkButton>
                                    <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandName="buyGoods" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"GoodsWeight")+"|"+DataBinder.Eval(Container.DataItem,"MemberPrice") %>'>Buy</asp:LinkButton></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
    </table>
</asp:Content>

