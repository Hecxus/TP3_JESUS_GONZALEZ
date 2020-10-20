<%@ Page Title=" " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--  --%>
    <div>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <div class ="container">
        
    <%--<div class="jumbotron">
        <h1>Mi Tienda</h1>
    </div>--%>

    <%--<asp:GridView ID="dgvArticulo" runat="server"></asp:GridView>--%>
    <div>
        <br />
        <asp:TextBox ID="searchText" runat="server"></asp:TextBox>
        <asp:Button ID="searchButton" runat="server" Text="Buscar" OnClick="searchButton_Click"  />
        <h5><asp:Label ID="lblBuscador" runat="server" Text="Utilice el buscador para buscar un articulo por su nombre"></asp:Label></h5>
        <br />
    </div>
    <section class ="container-section-articulos">
    <div class ="row">
        <div class ="col-md-12">
            <article class ="panel-articulos">
                <div class ="card-columns">
        <% foreach (var articulos in articulosAMostrar )
        {%>
           <div class="card" style="width: 18rem;">
             <img src="<%=articulos.Imagen %>" class="card-img-top img-fliud" alt="Card image">
               <div class="card-body">
                 <h5 onload="nuevoContenido()" class="card-title"><%=articulos.Nombre%></h5>
                    <p class="card-text"><% =articulos.Descripcion %></p>
                    <p class="card-text">$<% =articulos.Precio %></p> 
                    <a href="Detalle.aspx?id=<%= articulos.ID.ToString() %> " class="btn btn-primary">Ver detalle</a>
                   <%--<asp:Button ID="Agregar" runat="server" Text=<%=articulos.Nombre%> OnClick="Agregar_Click" CustomParameter=articulos.Nombre CommandArgument="@articulos.Nombre"  />--%>
                    
                   <%--<asp:Button OnClientClick="ScriptPrueba(articulos)" ID="Agregar" runat="server" Text="Agregar al carrito" OnClick="Agregar_Click" />--%>
               </div>
           </div>

        <%} %>
             </div>
            </article>
        </div>
    </div>
    </section>
    </div>

    </div>

    </div>
    <%--</div>--%>

</asp:Content>
