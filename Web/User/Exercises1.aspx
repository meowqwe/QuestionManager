<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="Exercises1.aspx.cs" Inherits="User_Exercises" %>

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
        <div style="float:right;padding-right:230px; height: 56px; width: 139px;">
                    正确答案：<br />
                    <asp:Label ID="lblAnswer" runat="server"></asp:Label>
        </div>
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
        <div style="float:left;padding-left:150px;">
            <asp:Button ID="Submit" Text="提交" runat="server" OnClick="Submit_Click" Height="21px" Width="53px" />
        </div>
        <div style="float:left;padding-left:250px;">
            <asp:Button ID="NEXT" Text="下一题" runat="server" Onclick="NEXT_Click" Height="20px" Width="57px"/>
        </div>
    </div>
</asp:Content>

