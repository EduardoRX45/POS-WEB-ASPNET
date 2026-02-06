<%@ Page Language="VB" AutoEventWireup="false" CodeFile="prods.aspx.vb" Inherits="prods" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos</title>
     <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f0f2f5;
            margin: 0;
            padding: 20px;
        }

        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 30px;
        }

        form > div {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            justify-content: center;
        }

        .ficha-producto {
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            padding: 15px;
            width: 250px;
            box-sizing: border-box;
            transition: transform 0.2s;
            display: flex;
            flex-direction: column;
            align-items: center;
            text-align: center;
        }

        .ficha-producto:hover {
            transform: translateY(-5px);
        }

        .ficha-producto img {
            width: 100%;
            height: 180px;
            object-fit: cover;
            border-radius: 8px;
            margin-bottom: 10px;
        }

        .ficha-producto p {
            margin: 6px 0;
            font-size: 15px;
            color: #555;
        }

        .ficha-producto p:first-child {
            font-weight: bold;
            font-size: 18px;
            color: #111;
        }

        .precio {
            color: #e91e63;
            font-weight: bold;
        }

        .stock {
            color: #4caf50;
            font-style: italic;
        }
    </style>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
        <div class="container">
        <a class="navbar-brand d-flex align-items-center" href="home.aspx">Cerrajería Cardoso</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav">
        <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav ms-auto">
        <li class="nav-item">
        <a class="nav-link active" href="home.aspx">Inicio</a>
        </li>
        <li class="nav-item">
        <a class="nav-link" href="home.aspx#servicios">Servicios</a>
        </li>
        <li class="nav-item">
        <a class="nav-link" href="#">Productos</a>
        </li>
        <li class="nav-item">
        <a class="nav-link" href="home.aspx#nosotros">Nosotros</a>
        </li>
        <li class="nav-item">
        <a class="nav-link" href="home.aspx#testimonios">Testimonios</a>
        </li>
        <li class="nav-item">
        <a class="nav-link" href="home.aspx#contacto">Contacto</a>
        </li>
        </ul>
        <div class="ms-lg-3 mt-3 mt-lg-0">
        <a href="login.aspx" class="btn btn-outline-light">Acceder</a>
        </div>
        </div>
        </div>
    </nav>

    <br />
    <br />
    <h1>Listado de Productos</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="repProductos" runat="server">
                <ItemTemplate>
                    <div class="ficha-producto">
                        <p><%# Eval("Nombre") %></p>
                        <img src='<%# Eval("Imagen") %>' alt="Imagen de <%# Eval("Nombre") %>" />
                        <p>Marca: <%# Eval("Marca") %></p>
                        <p><%# Eval("Descripcion") %></p>
                        <p class="precio">Precio: $<%# Eval("Precio") %></p>
                        <p class="stock">Stock: <%# Eval("Stock") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
