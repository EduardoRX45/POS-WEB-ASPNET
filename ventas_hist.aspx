<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ventas_hist.aspx.vb" Inherits="ventas_hist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
        <div class="content-container">
            <div class="title-content">
                <asp:Label ID="content_title" runat="server"></asp:Label>
            </div>

            <div class="table">
                <br />
                <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_ventasHistorial">
                    <Columns>
                        <asp:BoundColumn DataField="IdVenta"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Vendedor"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Estado"></asp:BoundColumn>
                        <asp:BoundColumn DataField="CantProds"></asp:BoundColumn>
                        <asp:BoundColumn DataField="GranTotal"></asp:BoundColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
        </div>
    </form>
</asp:Content>

