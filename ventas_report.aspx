<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ventas_report.aspx.vb" Inherits="ventas_report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <form id="form1" runat="server">
        <div class="content-container">
            <div class="title-content">
                <asp:Label ID="content_title" runat="server" Text="Generar Reporte de Ventas"></asp:Label>
            </div>

            <div class="content1-flexRow">
                <div>
                    <asp:Label ID="Label1" runat="server" CssClass="text-lb" Text="Fecha Inicio"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_Fecha1" runat="server" TextMode="Date" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" CssClass="text-lb" Text="Fecha Fin"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_Fecha2" runat="server" TextMode="Date" ></asp:TextBox>
                    <br />
                    <br />

                    <asp:Button ID="btn_ok" runat="server" CssClass="btn_ok" Text="Generar"/>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

