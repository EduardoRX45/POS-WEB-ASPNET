<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ventas_reporte_file.aspx.vb" Inherits="ventas_reporte_file" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8"/>
<title>Reporte de Ventas</title>

<!-- Librerías para PDF -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/2.5.1/jspdf.umd.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.29/jspdf.plugin.autotable.min.js"></script>

<script type="text/javascript">
    function guardarPDF() {
        const { jsPDF } = window.jspdf;
        const doc = new jsPDF();

        // Encabezado
        doc.setFontSize(16);
        doc.text("Reporte de Ventas", 14, 15);

        doc.setFontSize(10);
        doc.text(document.getElementById("<%= Label1.ClientID %>").innerText, 14, 25);
        doc.text(document.getElementById("<%= Label2.ClientID %>").innerText, 14, 30);
        doc.text(document.getElementById("<%= Label3.ClientID %>").innerText, 14, 35);
        doc.text(document.getElementById("<%= Label4.ClientID %>").innerText, 14, 40);
        doc.text(document.getElementById("<%= Label5.ClientID %>").innerText, 14, 45);
        doc.text(document.getElementById("<%= Label6.ClientID %>").innerText, 14, 50);

    // Tabla
    doc.autoTable({
        html: '#<%= dtg_repvent.ClientID %>',
        startY: 60,
        theme: 'grid',
        styles: { fontSize: 9 }
    });

        // Guardar PDF
        doc.save("ReporteVentas.pdf");
    }
</script>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <h1>Reporte de Ventas</h1>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        <asp:Label ID="Label2" runat="server"></asp:Label><br />
        <asp:Label ID="Label3" runat="server"></asp:Label><br />
        <asp:Label ID="Label4" runat="server"></asp:Label><br />
        <asp:Label ID="Label5" runat="server"></asp:Label><br />
        <asp:Label ID="Label6" runat="server"></asp:Label><br />

        <button type="button" onclick="guardarPDF()">Guardar PDF</button>
        <br /><br />

        <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_repvent">
            <Columns>
                <asp:BoundColumn DataField="IdVenta" HeaderText="IdVenta" />
                <asp:BoundColumn DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha" />
                <asp:BoundColumn DataField="Vendedor" HeaderText="Vendedor" />
                <asp:BoundColumn DataField="Estado" HeaderText="Estado" />
                <asp:BoundColumn DataField="CantProds" HeaderText="Cantidad Productos" />
                <asp:BoundColumn DataField="GranTotal" HeaderText="Total" />
                <asp:BoundColumn DataField="GranBeneficios" HeaderText="Beneficios" />
            </Columns>
        </asp:DataGrid>
    </div>
</form>
</body>
</html>
