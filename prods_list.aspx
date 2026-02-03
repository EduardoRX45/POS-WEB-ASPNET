<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="prods_list.aspx.vb" Inherits="prods_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title"></asp:Label>
            </div>

            <div class="table">
                <asp:Button ID="btn_newProd" runat="server" CssClass="btn_addItem"/>
				<asp:Button ID="btn_reportProd" runat="server" CssClass="btn_addItem"/>
                <br />
                <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_prods">
                    <Columns>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:Image ID="prod_img" runat="server" CssClass="prodlist_pic" ImageUrl='<%# Eval("Imagen") %>' Width="150px" Height="150px"/>
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="CodBarras"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Nombre"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Marca"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Descripcion"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Categoria"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Stock"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Costo"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Precio"></asp:BoundColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:Button runat="server" ID="btnRemove" CommandArgument='<%# Eval("IdProducto") %>' OnClick="btnRemove_Click" CssClass="btn_remove" />
                                <asp:Button runat="server" ID="btnEdit" CommandArgument='<%# Eval("IdProducto") %>' OnClick="btnEdit_Click" CssClass="btn_edit" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
        </div>
    </form>
</asp:Content>

