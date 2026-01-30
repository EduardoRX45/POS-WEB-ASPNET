<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="services_list.aspx.vb" Inherits="services_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title" Text="Servicios"></asp:Label>
            </div>

            <div class="table">
                <asp:Button ID="btn_newServ" runat="server" CssClass="btn_addItem" Text="Agregar Servicio"/>
                <br />
                <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_serv">
                    <Columns>
<%--                        <asp:TemplateColumn HeaderText="Imagen">
                            <ItemTemplate>
                                <asp:Image ID="serv_img" runat="server" CssClass="prodlist_pic" ImageUrl='<%# Eval("Imagen") %>' Width="150px" Height="150px"/>
                            </ItemTemplate>
                        </asp:TemplateColumn>--%>
                        <asp:BoundColumn DataField="Nombre" HeaderText="Nombre" ></asp:BoundColumn>
                        <asp:BoundColumn DataField="Descripcion" HeaderText="Descripcion"></asp:BoundColumn>
                        <asp:TemplateColumn HeaderText="Accion" > 
                            <ItemTemplate>
                                <asp:Button runat="server" ID="btnRemove" CommandArgument='<%# Eval("IdServicio") %>' OnClick="btnRemove_Click" CssClass="btn_remove" />
                                <asp:Button runat="server" ID="btnEdit" CommandArgument='<%# Eval("IdServicio") %>' OnClick="btnEdit_Click" CssClass="btn_edit" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
        </div>
    </form>
</asp:Content>

