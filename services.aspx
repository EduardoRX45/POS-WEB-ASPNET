<%@ Page Language="VB" AutoEventWireup="false" CodeFile="services.aspx.vb" Inherits="services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Repeater ID="repServicios" runat="server">
                <ItemTemplate>
                    <div class="col-md-6 col-lg-4">
                        <div class="service-card bg-white p-4 h-100">
                            <div class="service-icon text-center"><img src='<%#Eval("Imagen") %>' /></div>
                            <h4 class="text-center mb-3"><%# Eval("Nombre") %></h4>
                            <p class="text-muted"><%# Eval("Descripcion") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
