<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="Regist.aspx.cs" Inherits="Admin_AdminMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
        <style>
    li{
        list-style:none;
    }
</style>
        <ul>
            <li>
                &nbsp;&nbsp;&nbsp;用户名：
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </li>
            <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator1" 
                    runat="server" 
                    ErrorMessage="必须填写用户名" 
                    ControlToValidate="txtName">
                </asp:RequiredFieldValidator>
            </li>
            <li>&nbsp;&nbsp;&nbsp;&nbsp;密码：
                <asp:TextBox ID="txtPwd" 
                    runat="server" 
                    TextMode="Password">
                </asp:TextBox>
            </li>
            <li>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator 
                    ID="RequiredFieldValidator2" 
                    runat="server"
                    ErrorMessage="必须填写密码"
                    ControlToValidate="txtPwd">
                </asp:RegularExpressionValidator>
            </li>
            <li>
                &nbsp;&nbsp;&nbsp;&nbsp;班级：
                <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
            </li>
            <li></li>
            <li>&nbsp;&nbsp;&nbsp;&nbsp;年级：
                <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
            </li>
            <li></li>
            <li>
                &nbsp;&nbsp;&nbsp;&nbsp;性别：
                <asp:RadioButton ID="RadioButton1" runat="server" 
                    Checked="true" Text="男" GroupName="role" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server"
                    Text="女" GroupName="role" />
            </li>
            <li></li>
            <li>
                &nbsp;&nbsp;&nbsp;用户组：
                <asp:RadioButton ID="rdUser" runat="server" 
                    Checked="true" Text="用户" GroupName="role" />
                &nbsp;
                <asp:RadioButton ID="rdAdmin" runat="server"
                    Text="管理员" GroupName="role" />
            </li>
            <li></li>
            <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAdd" runat="server" 
                    Text="添加" CssClass="input_button"
                    OnClick="btnAdd_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="btnReset" runat="server" 
                    Text="重置" CssClass="input_button"
                    OnClick="btnReset_Click" />
            </li>
        </ul>
</asp:Content>

