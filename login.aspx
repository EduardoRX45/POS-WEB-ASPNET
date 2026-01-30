<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
    <link rel="stylesheet" runat="server" media="screen" href="css/login.css" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="item2">
                <asp:Label ID="welcome_msg" runat="server" CssClass="title"></asp:Label> 
                <br />
                <asp:Label ID="error_msg" runat="server"></asp:Label>
                <asp:TextBox ID="email" runat="server" placeholder="" TextMode="Email" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:TextBox ID="pass" runat="server" placeholder="" TextMode="Password" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:Button ID="btn_login" runat="server" CssClass="btn_login"/>
                <br />
                <asp:Button ID="btn_fp" runat="server" UseSubmitBehavior="false" CssClass="btn_link" />
                <br />
                <asp:Button ID="btn_fp2" runat="server" UseSubmitBehavior="false" CssClass="btn_link" />
                <br />
                <asp:Button ID="btn_fp3" runat="server" UseSubmitBehavior="false" CssClass="btn_link" Text="Regresar" />
            </div>

        </div>
    </form>
</body>
</html>
