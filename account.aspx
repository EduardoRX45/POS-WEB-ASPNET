<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="account.aspx.vb" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">

        <div class="account-container">

            <div class="account-content1">
                <div class="title-content">
                    <asp:Label ID="content1_title" runat="server" CssClass="title"></asp:Label>
                </div>

                <asp:Label ID="Label_accountMsg" runat="server" CssClass="text-lb"></asp:Label>

                <div class="account-content1-data">
                    <div>
                        <asp:Label ID="Label_nombre" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox_nombre" runat="server" CssClass="input_txt"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label_appat" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox_appat" runat="server" CssClass="input_txt" minlength="1" ></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label_apmat" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox_apmat" runat="server" CssClass="input_txt"></asp:TextBox>

                    </div>

                    <div>
                        <asp:Label ID="Label_correo" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox_correo" runat="server" ReadOnly="false" TextMode="Email" CssClass="input_txt"></asp:TextBox>
                        <br />
                        <br />
<%--                        <asp:Label ID="Label_telf" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox_telf" runat="server" ReadOnly="false" TextMode="Number" MaxLength="10" CssClass="input_txt"></asp:TextBox>
                        <br />
                        <br />--%>
                        <asp:Label ID="Label_img" runat="server" CssClass="text-lb"></asp:Label>
                        <br />
                        <asp:FileUpload ID="FileUpload_img" runat="server"/>
                        <br />
                    </div>

                    <div>
                        <asp:Image ID="user_img" runat="server" CssClass="userlist_pic" Width="150px" Height="150px"/>
                    </div>
                </div>

                <div>
                    <asp:Button ID="btn_save" runat="server" CssClass="btn_ok"/>
    <%--                <asp:HyperLink ID="btn_cancel" runat="server" NavigateUrl="~/dashboard.aspx" CssClass="btn_cancel"></asp:HyperLink>--%>
                </div>
            </div>

            <div class="account-content2">
                <div class="title-content">
                    <asp:Label ID="content2_title" runat="server" CssClass="title"></asp:Label>
                </div>

                <asp:Label ID="Label_contraMsg" runat="server" CssClass="text-lb"></asp:Label>
                <br />
                <asp:Label ID="Label_contra" runat="server" CssClass="text-lb"></asp:Label>
                <asp:TextBox ID="TextBox_contra" runat="server" CssClass="input_txt" TextMode="Password" ></asp:TextBox>
                <br />
                <asp:Label ID="Label_newContra" runat="server" CssClass="text-lb"></asp:Label>
                <asp:TextBox ID="TextBox_newContra" runat="server" CssClass="input_txt" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Label ID="Label_newContraConf" runat="server" CssClass="text-lb"></asp:Label>
                <asp:TextBox ID="TextBox_newContraConf" runat="server" CssClass="input_txt" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="btn_saveContra" runat="server" CssClass="btn_ok"/>
            </div>

        </div>
    </form>
</asp:Content>

