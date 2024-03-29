﻿<%@ Page Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="MyFavorite.aspx.cs" Inherits="User_Favorite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" runat="server">
    <script lang="javascript" type="text/javascript" src="../My97DatePicker/WdatePicker.js" charset="gb1312">
    </script>
    <table>
            <tr>
                <td style="font-size:large;font-weight:bold; height: 22px;">
                    收藏夹名称：
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="BtnCreate" runat="server" Text="创建收藏夹" CssClass="input_button"
            Onclick="BtnCreate_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="odsFavorite" Height="185px" Width="654px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
            <Columns>
                <asp:BoundField DataField="Fname1" HeaderText="收藏名" SortExpression="Fname1" />
                <asp:BoundField DataField="QBnumber1" HeaderText="题库数量" SortExpression="QBnumber1" />
                <asp:CommandField ShowEditButton="True" />

                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandArgument='<%# Eval("Fname1") %>' CommandName="Choose" Text="选择" OnClick="LinkButton1_Click"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsFavorite" runat="server" DataObjectTypeName="QBModels.Favorite" DeleteMethod="DeleteFavorite" InsertMethod="CreateBlankFavorite" SelectMethod="GetAllFavorite" TypeName="QBBLL.FavoriteManager" UpdateMethod="ModifyFavorite">
            <SelectParameters>
                <asp:SessionParameter Name="User" SessionField="CurUser" Type="Object" />
            </SelectParameters>
        </asp:ObjectDataSource>
        
</asp:Content>
