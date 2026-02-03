<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ticket.aspx.vb" Inherits="ticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link ID="estiloCss" rel="stylesheet" runat="server" media="all" href="css/ticket.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ticket">
            <div class="datos1">
                <p>Ticket de Venta</p>
                <p>Cerrajeria Cardoso</p>
                <p>Av Fraternidad S/N, Barrio de San Marcos<br />Yachihualcaltepec, Toluca, México</p>
                <p>--------------------------------------------------------------------</p>
            </div>
            <div class="datos2">
                <asp:Label ID="Label_IDVenta" runat="server"></asp:Label> <asp:Label ID="Label_vendedor" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label_fecha" runat="server"></asp:Label> <asp:Label ID="Label_hora" runat="server"></asp:Label>
                <p>Nombre....................Cantidad....................Total</p>
                <p>--------------------------------------------------------------------</p>   
            </div>
            <div class="prods">
                <asp:Repeater runat="server" ID="repDVProds">
                    <ItemTemplate>
                        <div class="prods-item">
                            <p><%# Eval("ProductoNom") %></p>
                            <p> <%# Eval("Cantidad") %></p>
                            <p> <%# Eval("Total") %></p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="balance">
                <p>--------------------------------------------------------------------</p>
                <asp:Label ID="Label_total" runat="server"></asp:Label>
                <p>Gracias por su Compra</p>
            </div>
        </div>
        <button id="printButton" class="btnPrint">Imprimir</button>
    </form>
        <script>
            document.addEventListener('DOMContentLoaded', function() {
            const printButton = document.getElementById('printButton');
            if (printButton) {
            printButton.addEventListener('click', function() {
                window.print();
            });
            }
            });
        </script>
</body>
</html>
