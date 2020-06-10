<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="FavoriteQB.aspx.cs" Inherits="User_FavoriteQB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table>
        <tr>
            <th style="height: 110px; width: 128px">
                输入收藏夹名：
            </th>
            <th style="height: 110px; width: 186px">
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </th>
        </tr>
    </table>
    <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" />
</asp:Content>

