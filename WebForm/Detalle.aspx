﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <section>
    <div>
        <h4>Detalle del articulo:</h4>
    </div>
    <div>
        <img style="float:left" src=" <%=articulo.Imagen%>" alt="Imagen de prueba" width="500" height="600" />
            </div>
        <div>
        <h4 >Nombre: <%=articulo.Nombre%></h4>
        <h4 >Descripcion:  <%=articulo.Descripcion%></h4>
            <h4 >Marca:  <%=articulo.marca%></h4>
            <h4 >Categoria:  <%=articulo.categoria%></h4>
            <br />
        <h3 style="margin-bottom:300px">Precio: $   <%=articulo.Precio%> </h3>

            <asp:Button CssClass="Button" ID="Agregar" runat="server" Text="Agregar al carrito" 
                style=" 
                  background-color: #4CAF50;
                  border: none;
                  color: white;
                  padding: 15px 10px;
                  text-align: center;
                  text-decoration: none;
                  display: inline-block;
                  font-size: 16px;"/>
            <asp:Button CssClass="Button" ID="Volver" runat="server" Text="Volver" 
                style=" 
                  background-color: #4CAF50;
                  border: none;
                  color: white;
                  padding: 15px 40px;
                  text-align: center;
                  text-decoration: none;
                  display: inline-block;
                  font-size: 16px;"/>

    </div>

    </section>
</asp:Content>