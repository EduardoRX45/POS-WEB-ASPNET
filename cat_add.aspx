<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="cat_add.aspx.vb" Inherits="cat_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <div class="content-container">

            <div class="title-content">
                <asp:Label ID="content_title" runat="server" CssClass="title"></asp:Label>
            </div>

            <div class="content1">
                <asp:Label ID="Label_nombre" runat="server" CssClass="text-lb"></asp:Label>
                <asp:TextBox ID="TextBox_nombre" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                <br />
                <asp:Label ID="Label_desc" runat="server" CssClass="text-lb"></asp:Label>
                <asp:TextBox ID="TextBox_desc" runat="server" required="true" CssClass="input_txt"></asp:TextBox>
                <br />

                <asp:Button ID="btn_save" runat="server" CssClass="btn_ok" />
                <asp:HyperLink ID="btn_cancel" runat="server" NavigateUrl="~/cat_list.aspx" CssClass="btn_cancel"></asp:HyperLink>
            </div>
        </div>
    </form>
</asp:Content>

