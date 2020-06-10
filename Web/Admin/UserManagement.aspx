<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="UserManagement.aspx.cs" Inherits="Admin_UserManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="odsUser" Height="210px" Width="698px">
        <Columns>
            <asp:BoundField DataField="UuserName1" HeaderText="姓名" SortExpression="UuserName1" />
            <asp:BoundField DataField="UpassWord1" HeaderText="密码" SortExpression="UpassWord1" />
            <asp:DynamicField DataField="Usex1" HeaderText="性别" />
            <asp:BoundField DataField="Uclass1" HeaderText="班级" SortExpression="Uclass1" />
            <asp:BoundField DataField="Ugrade1" HeaderText="年级" SortExpression="Ugrade1" />
            <asp:BoundField DataField="Urole1" HeaderText="权限" SortExpression="Urole1" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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
    <asp:ObjectDataSource ID="odsUser" runat="server" DataObjectTypeName="QBModels.User" DeleteMethod="DeleteUser" InsertMethod="AddUser" SelectMethod="GetAllUsers" TypeName="QBBLL.UserManager" UpdateMethod="ModifyUser"></asp:ObjectDataSource>
    <asp:Button ID="AddUser" runat="server" Text="添加新用户" OnClick="AddUser_Click" />
</asp:Content>

