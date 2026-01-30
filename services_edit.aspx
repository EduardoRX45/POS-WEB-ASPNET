<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="services_edit.aspx.vb" Inherits="services_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title" Text="Editar Servicio"></asp:Label>
            </div>

            <div class="content1-flexRow">
                <div>
                    <asp:Label ID="Label_nombre" runat="server" CssClass="text-lb" Text="Nombre"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_nombre" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label_desc" runat="server" CssClass="text-lb" Text="Descripcion"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox_desc" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                    <br />
                    <br />
<%--                    <asp:Label ID="Label_img" runat="server" CssClass="text-lb" Text="Imagen"></asp:Label>
                    <br />
                    <asp:FileUpload ID="FileUpload_imgServ" runat="server"/>
                    <br />--%>
                </div>

<%--                <div>
                    <asp:Image ID="serv_img" runat="server" CssClass="userlist_pic" Width="150px" Height="150px"/>
                </div>--%>
            </div>

            <div>
                <asp:Button ID="btn_save" runat="server" CssClass="btn_ok" Text="Actualizar"/>
                <asp:HyperLink ID="btn_cancel" runat="server" NavigateUrl="~/services_list.aspx" CssClass="btn_cancel" Text="Cancelar"></asp:HyperLink>
            </div>

        </div>
    </form>
</asp:Content>

