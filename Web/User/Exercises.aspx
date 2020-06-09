<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="Exercises.aspx.cs" Inherits="User_Exercises" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <div>
        <table style="font-size:16px;">
            <tr>
                <td style="width: 135px; height: 17px">
                    题目类型：<asp:Label ID="lblType" runat="server"></asp:Label>
                </td>
                <td style="width: 133px; height: 17px;">
                    学科：<asp:Label ID="lblSubject" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 135px" class="middle-left">
                    题干：
                </td>
            </tr>
        </table>
        <table style="font-size:30px;">
            <tr>
                <td style="width: 602px; height: 64px">
                    <asp:Label ID="lblStem" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="font-size:16px;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblA" runat="server"></asp:Label>
                    <asp:Label ID="lblAtext" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblB" runat="server"></asp:Label>
                    <asp:Label ID="lblBtext" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblC" runat="server"></asp:Label>
                    <asp:Label ID="lblCtext" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblD" runat="server"></asp:Label>
                    <asp:Label ID="lblDtext" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div style="font-size:18px;">
            答案：
            <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>

