<%@ Page Title=" " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <div class ="container">

    <%--<div class="jumbotron">
        <h1>Mi Tienda</h1>
    </div>--%>

    <%--<asp:GridView ID="dgvArticulo" runat="server"></asp:GridView>--%>
    
    <section class ="container-section-articulos">
    <div class ="row">
        <div class ="col-md-12">
            <article class ="panel-articulos">
                <div class ="card-columns">
        <% foreach (var articulos in listaArticulos )
        {%>
           <div class="card" style="width: 18rem;">
                 <img src="<%=articulos.Imagen %>" class="card-img-top img-fliud" alt="Card image">
                      <div class="card-body">
                        <h5 class="card-title"><%=articulos.Nombre%></h5>
                           <p class="card-text"><% =articulos.Descripcion %></p>
                              <p class="card-text">$<% =articulos.Precio %></p> 
                              <a href="#" class="btn btn-primary">Añadir a Carrito</a>
                      </div>
           </div>
              
                
        <%} %>
             </div>
            </article>
        </div>
    </div>
    </section>
    </div>

</asp:Content>
