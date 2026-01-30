<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ventas_new.aspx.vb" Inherits="ventas_new" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">

        <div class="ventas-container">

            <div class="ventas-content1">
                <div class="title-content">
                    <asp:Label ID="content_title1" runat="server" CssClass="titleLabel"></asp:Label>
                </div>

                <div class="add-prods">
                    <asp:DropDownList ID="ddl_prods" runat="server" CssClass="ddl"></asp:DropDownList>
                    <asp:TextBox ID="TextBox_cant" runat="server" Text="1" TextMode="Number" CssClass="input_txt"></asp:TextBox>
                    <asp:Button ID="btn_add" runat="server" Text="+" />
                </div>

                <div class="table">
                    <asp:DataGrid runat="server" AutoGenerateColumns="false" ID="dtg_prodsDetVent">
                        <Columns>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnRemove" CommandArgument='<%# Eval("IdProducto") %>' OnClick="btnRemove_Click" CssClass="btn_remove"/>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="ProductoNom"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Cantidad"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrecioUnit"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Total"></asp:BoundColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>

            <div class="ventas-content2">
                <div class="ventas-details">
                    <div class="title-content">
                        <asp:Label ID="content_title2" runat="server" CssClass="title"></asp:Label>
                    </div>
                    <asp:Label ID="Label_idTxt" runat="server" Text="ID: " CssClass="text-lb"></asp:Label>
                    <asp:Label ID="Label_idVent" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:Label ID="Label_cantArt" runat="server" CssClass="text-lb"></asp:Label>
                    <asp:Label ID="Label_cantArtNo" runat="server" CssClass="text-lb"></asp:Label>
                    <br />
                    <asp:Label ID="Label_total" runat="server" CssClass="text-lb"></asp:Label>
                    <asp:Label ID="Label_totalNo" runat="server" CssClass="text-lb"></asp:Label>
                </div>

                <div class="ventas-conf">
                    <asp:Label ID="lb_checkMSG" runat="server" CssClass="text-lb"></asp:Label>
                    <asp:Button ID="btn_conf" runat="server" CssClass="btn_ventConf"/>
                    <asp:Button ID="btn_cancel" runat="server" CssClass="btn_ventCancel"/>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

