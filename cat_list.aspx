<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="cat_list.aspx.vb" Inherits="cat_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title"></asp:Label>
            </div>

            <div class="table">
                <asp:Button ID="btn_newCat" runat="server" CssClass="btn_addItem"/>
                <br />
                <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_cat">
                    <Columns>
                        <asp:BoundColumn DataField="Nombre"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Descripcion"></asp:BoundColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:Button runat="server" ID="btnRemove" CommandArgument='<%# Eval("IdCategoria") %>' OnClick="btnRemove_Click" CssClass="btn_remove" />
                                <asp:Button runat="server" ID="btnEdit" CommandArgument='<%# Eval("IdCategoria") %>' OnClick="btnEdit_Click" CssClass="btn_edit" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
        </div>
    </form>
</asp:Content>

