<%@ Page Title="Dashboard" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="dashboard.aspx.vb" Inherits="dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="page-title">
        <asp:Label runat="server" Text="Inicio" ID="titulo_pagina" CssClass="page_title"></asp:Label>
    </div>

    <div class="db_boxes">        
        <div class="box1">
            <br />
            <asp:Label runat="server" ID="total_sales" CssClass="boxDB_text"></asp:Label>
            <br />
            <asp:Label runat="server" ID="total_sales_no" CssClass="box_number"></asp:Label>
        </div>
        
        <div class="box2">
            <br />
            <asp:Label runat="server" ID="total_revenue" CssClass="boxDB_text"></asp:Label>
            <br />
            <asp:Label runat="server" ID="total_revenue_no" CssClass="box_number"></asp:Label>
        </div>
        
        <div class="box3">
            <br />
            <asp:Label runat="server" ID="total_prods" CssClass="boxDB_text"></asp:Label>
            <br />
            <asp:Label runat="server" ID="total_prods_no" CssClass="box_number"></asp:Label>
        </div>
        
        <div class="box4">
            <br />
            <asp:Label runat="server" ID="total_cat" CssClass="boxDB_text"></asp:Label>
            <br />
            <asp:Label runat="server" ID="total_cat_no" CssClass="box_number"></asp:Label>
        </div>
    </div>

</asp:Content>

