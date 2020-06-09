<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="AddBlankQuestionBank.aspx.cs" Inherits="Admin_AddBlankQuestionBank" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table style="width: 660px; height: 156px">
        <tr>
            <th class="middle-left" style="width: 243px;font-size:40px;">
                题库名：
            </th>
            <th>
                <asp:TextBox ID="txtQBname" runat="server" Height="60px" Width="310px"></asp:TextBox>
            </th>
        </tr>
    </table>
    <asp:Button ID="Submit" Text="提交" runat="server" OnClick="Submit_Click" Height="33px" Width="279px" />
</asp:Content>

