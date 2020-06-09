<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="QuestionBankManagement.aspx.cs" Inherits="Admin_QuestionBankManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="odsQuestionBank" Height="221px" Width="593px">
        <Columns>
            <asp:BoundField DataField="QBnum1" HeaderText="数据库号" SortExpression="QBnum1" />
            <asp:BoundField DataField="QBname1" HeaderText="数据库名" SortExpression="QBname1" />
            <asp:BoundField DataField="QBqnum1" HeaderText="题目数量" SortExpression="QBqnum1" />
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
    <asp:ObjectDataSource ID="odsQuestionBank" runat="server" DataObjectTypeName="QBModels.QuestionBank" DeleteMethod="DeleteQuestionBank" InsertMethod="CreateBlankQuestionBank" SelectMethod="GetAllQuestionBank" TypeName="QBBLL.QuestionBankManager" UpdateMethod="ModifyQuestionBank"></asp:ObjectDataSource>
    <asp:Button ID="AddQUestionBank" runat="server" Text="添加新题库" OnClick="AddQUestionBank_Click" />
</asp:Content>

