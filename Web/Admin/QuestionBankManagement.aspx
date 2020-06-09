<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="QuestionBankManagement.aspx.cs" Inherits="Admin_QuestionBankManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table>
        <tr>
            <td>
                数据库名：<asp:TextBox ID="txtQBname" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnSearch" Text="查询" runat="server" OnClick="btnSearch_Click" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="odsQuestionBank" Height="177px" Width="546px">
        <Columns>
            <asp:BoundField DataField="QBname1" HeaderText="题库名" SortExpression="QBname1" />
            <asp:BoundField DataField="QBqnum1" HeaderText="题目数量" SortExpression="QBqnum1" />
            <asp:CommandField ShowSelectButton="True" />
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
    <asp:ObjectDataSource ID="odsQuestionBank" runat="server" SelectMethod="GetQuestionBankBySql" TypeName="QBBLL.QuestionBankManager">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="safeSql" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="GridView1" Name="values" PropertyName="SelectedValue" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

