<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.WebForm1" %>

<asp:Content ID="Carrito" ContentPlaceHolderID="MainContent" runat="server">
    <article class ="panel-articulos">
        <%foreach (var articulos in listaArticulos)
            {%>

            <div class="media">
                <img width="30" height="30" src="<%=articulos.Imagen %>" class="align-self-start mr-3" alt="image">
                <div class="media-body">
                  <%--  <ul class="navbar-nav mr-auto mt-2 mt-lg-0">  --%>
                        <%--<li class="navbar-nav">--%>
                        <form class="form-inline my-2 my-lg-0">    
                            <h5 class="mt-0"><%=articulos.Nombre%></h5>  
                        </form>    
                        <%--</li>  --%>  
                        <%--<li class="navbar-nav">--%>
                        <form class="form-inline my-2 my-lg-0">
                            <h5 class="mt-0"><%=articulos.Precio %></h5>
                        </form>
                        <%--</li>--%>
                    <%--</ul>--%>
                    
                   
                </div>
              </div>
            <%} %>
    </article>
</asp:Content>
