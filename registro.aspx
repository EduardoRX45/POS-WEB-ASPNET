<%@ Page Language="VB" AutoEventWireup="false" CodeFile="registro.aspx.vb" Inherits="registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" runat="server" media="screen" href="css/login.css" />
    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="item2">
                <asp:Label ID="welcome_msg" runat="server" CssClass="title" Text="Registrar Usuario"></asp:Label> 
                <br />
                <asp:Label ID="mensaje" runat="server"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" placeholder="Nombre" runat="server" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox2" placeholder="Apellido Paterno" runat="server" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox3" placeholder="Apellido Materno" runat="server" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
<%--                <asp:TextBox ID="TextBox4" placeholder="Telefono" runat="server" TextMode="Number" CssClass="input_tb" required="true"></asp:TextBox>
                <br />--%>
                <asp:TextBox ID="email" placeholder="Correo" runat="server" TextMode="Email" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:TextBox ID="pass" placeholder="Contraseña" runat="server" TextMode="Password" CssClass="input_tb" required="true"></asp:TextBox>
                <br />
                <asp:Button ID="btn_reg" runat="server" CssClass="btn_login" Text="Registrar Usuario"/>
                <br />
                <asp:Button ID="btn_link" runat="server" UseSubmitBehavior="false" Text="Regresar" CssClass="btn_link" />
            </div>

        </div>
    </form>
</body>
</html>
