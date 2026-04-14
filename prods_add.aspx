<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="prods_add.aspx.vb" Inherits="prods_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title"></asp:Label>
            </div>

            <div class="content1-flexRow">

                <div>
                    <asp:Label ID="lb_checkMSG" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:Label ID="Label_nombre" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_nombre" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_marca" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_marca" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_codbarr" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_codbarr" runat="server" TextMode="Number" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_desc" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_desc" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_cat" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:DropDownList ID="DropDownList_cat" runat="server" CssClass="ddl"></asp:DropDownList>
                    <br />
                </div>

                <div>
                    <asp:Label ID="Label_stock" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_stock" runat="server" TextMode="Number" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_costo" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_costo" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label_precio" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_precio" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                </div>
            </div>

            <div>
                <asp:Button ID="btn_save" runat="server" CssClass="btn_ok"/>
                <asp:HyperLink ID="btn_cancel" runat="server" NavigateUrl="~/prods_list.aspx" CssClass="btn_cancel"></asp:HyperLink>
            </div>
        </div>
    </form>
    
<script>
    const input = document.getElementById("<%= TextBox_costo.ClientID %>");
    const input2 = document.getElementById("<%= TextBox_precio.ClientID %>");
    input.addEventListener("input", function () {
        // Permite números y un solo punto decimal
        this.value = this.value
            .replace(/[^0-9.]/g, '')     // elimina todo excepto números y punto
            .replace(/(\..*)\./g, '$1'); // evita más de un punto
    });
    input2.addEventListener("input", function () {
        // Permite números y un solo punto decimal
        this.value = this.value
            .replace(/[^0-9.]/g, '')     // elimina todo excepto números y punto
            .replace(/(\..*)\./g, '$1'); // evita más de un punto
    });

</script>
</asp:Content>

