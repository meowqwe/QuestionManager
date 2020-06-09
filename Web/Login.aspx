<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>用户登录</title>
    <style>
    li{
        list-style:none;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li>
                用户名：
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
            <li>&nbsp;&nbsp;&nbsp;密码：&nbsp;
                <asp:TextBox ID="txtPwd" 
                    runat="server" 
                    TextMode="Password">
                </asp:TextBox>
            </li>
            <li>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2" 
                    runat="server"
                    ErrorMessage="必须填写密码"
                    ControlToValidate="txtPwd">
                </asp:RequiredFieldValidator>
            </li>
            <li></li>
            <li>
                用户组： <asp:RadioButton ID="rdUser" runat="server" 
                    Checked="true" Text="用户" GroupName="role" />
                &nbsp;
                <asp:RadioButton ID="rdAdmin" runat="server"
                    Text="管理员" GroupName="role" />
            </li>
            <li>&nbsp;&nbsp;</li>
            <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="btnLogin" runat="server" 
                    Text="登录" CssClass="input_button"
                    OnClick="btnLogin_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="btnReset" runat="server" 
                    Text="重置" CssClass="input_button"
                    OnClick="btnReset_Click" />
            </li>
        </ul>
    </form>
</body>
</html>
