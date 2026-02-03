<%@ Page Language="VB" AutoEventWireup="false" CodeFile="prods_reporte_file.aspx.vb" Inherits="prods_reporte_file" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Reporte de Inventario</title>

<!-- Librerías para PDF -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/2.5.1/jspdf.umd.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.29/jspdf.plugin.autotable.min.js"></script>

<script>
    function guardarPDF() {
        const { jsPDF } = window.jspdf;
        const doc = new jsPDF();

        doc.text("Reporte de Inventario", 14, 15);

        // Convierte la tabla en PDF
        doc.autoTable({
            html: '#<%= dtg_prodsReport.ClientID %>', // Obtiene la tabla del DataGrid
            startY: 25,
            theme: 'grid',
            styles: { fontSize: 8 }
        });

        doc.save("ReporteInventario.pdf");
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Reporte de Inventario</h1>
            <button type="button" onclick="guardarPDF()">Guardar PDF</button>
            <br /><br />
            <asp:DataGrid ID="dtg_prodsReport" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundColumn DataField="CodBarras" HeaderText="Codigo" />
                    <asp:BoundColumn DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundColumn DataField="Marca" HeaderText="Marca" />
                    <asp:BoundColumn DataField="Categoria" HeaderText="Categoria" />
                    <asp:BoundColumn DataField="Stock" HeaderText="Stock" />
                    <asp:BoundColumn DataField="Costo" HeaderText="Costo" />
                    <asp:BoundColumn DataField="Precio" HeaderText="Precio" />
                </Columns>
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
