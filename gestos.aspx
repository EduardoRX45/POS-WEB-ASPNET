<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="gestos.aspx.vb" Inherits="gestos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <asp:Button id="btn_com" runat="server" Text="Button" />
        <asp:Literal ID="Resultado" runat="server" />
    </form>
</asp:Content>

