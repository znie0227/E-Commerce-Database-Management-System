﻿  <%@ Control Language="C#" AutoEventWireup="true" CodeFile="navigationControl.ascx.cs" Inherits="UserControl_navigationControl" %>
 <%-- <%@ OutputCache Duration ="15" VaryByParam="None" %>--%>
 <table  style="width: 220px; height: 549px; font-size: 9pt; font-family: Times New Roman; vertical-align :top ;"  background ="../Images/index/leftmenubackground.jpg" border="0" cellpadding="0" cellspacing="0" >
    <tr valign =top  align =center >
        <td>
        <br />
        <br />
        <br />
        <br />
        <br />
         <asp:DataList ID="DLClass" runat="server" DataKeyField="ClassID" OnEditCommand="DLClass_EditCommand"   >
           
                <ItemTemplate>
                    <table >
                        <tr>
                        <td align =left  style ="width :28px; height :23px;">
                        <asp:Image ID="imageRefine" runat="server"  ImageUrl =<%#DataBinder.Eval(Container.DataItem,"CategoryUrl")%> />
                        </td>
                      <td> </td>
                            <td align =left style ="width :80px; font-size: 9pt; font-family: Times New Roman;" > 
                            <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="Edit" CausesValidation="False" ><%# DataBinder.Eval(Container.DataItem, "ClassName") %></asp:LinkButton>
                            </td>
                        </tr>
                        
                    </table>
                    
                </ItemTemplate>
            </asp:DataList>
         
            
            </td>
    </tr>
</table>

