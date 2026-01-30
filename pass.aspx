<%@ Page Language="VB" AutoEventWireup="false" CodeFile="pass.aspx.vb" Inherits="pass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
    <title>Password</title>
    <link rel="stylesheet" runat="server" media="screen" href="css/login.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="item2">
                <asp:Label ID="title" runat="server" CssClass="title"></asp:Label>
                <br />
                <asp:Label ID="msg" runat="server"></asp:Label>
                <asp:Label ID="msg2" runat="server"></asp:Label>
                <br />
                <asp:Label ID="msg_rp" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="email" runat="server" placeholder="" TextMode="Email" CssClass="input_tb"></asp:TextBox>
                <br />
                <asp:Button ID="btn" runat="server" CssClass="btn_login"/>
                <br />
                <asp:HyperLink ID="login_hl" runat="server" NavigateUrl="login.aspx"></asp:HyperLink>
            </div>

        </div>
    </form>
</body>
</html>
