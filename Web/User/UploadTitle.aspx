<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="UploadTitle.aspx.cs" Inherits="User_UploadTitle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <table>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                题干：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtStem" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                学科：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtSubject" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                题目类型：
            </td>
            <td style="height: 22px;font-size:large;font-weight:bold;">
                <asp:RadioButton ID="rdXuanze" Text="选择" runat="server" Checked="true" GroupName="Subject"/>
                <asp:RadioButton ID="rdTiankong" Text="填空" runat="server" GroupName="Subject" />
                <asp:RadioButton ID="rdPanduan" Text="判断" runat="server" GroupName="Subject" />
                <asp:RadioButton ID="rdJianda" Text="简答" runat="server" GroupName="Subject" />
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                选项A：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtA" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                选项B：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtB" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                选项C：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtC" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                选项D：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtD" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size:large;font-weight:bold; height: 22px;">
                答案：
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtAnswer" runat="server" Height="17px" Width="431px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div>
        <asp:Button ID="btnSubmit" Text="提交" runat="server" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>

