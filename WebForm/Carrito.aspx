<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.WebForm1" %>



<asp:Content ID="Carrito" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function evaluarBotonCompra() {
            var bool = "<%= EvaluarBotonCompra() %>"
            var btnComprar = document.getElementById("<%=btnComprar.ClientID %>");

            if (bool=="true") {
                btnComprar.disabled = false;
            } else {
                btnComprar.disabled = true;
            }
            //alert(bool);
        }
    </script>

    <article class ="panel-articulos">
    <table class="table">
    <thead class="thead-dark">
        <tr>
          <th scope="col"> </th>
          <th scope="col">Nombre</th>
          <th scope="col">Precio</th>
          <th scope="col">Cantidad</th>
          <th scope="col">Total</th>
        </tr>
    </thead>
    
        <%foreach (var articulos in listaArticulos)
          {%>
                
                <%--<table class="table  table-striped">--%>
                <tbody >
                    <tr>
                      <th scope="row"><img width="30" height="30" src="<%=articulos.Imagen %>"" alt="image"></th>
                      <td> <%=articulos.Nombre%></td>  
                      <td>$<%=articulos.Precio %></td>
                      <td>#Boton eliminar?</td>
                      <td><a href="Carrito.aspx?deleteid=<%= articulos.ID.ToString() %> " class="btn btn-primary" onclick="evaluarBotonCompra()">X</a></td>
                    </tr>
                </tbody>
        <%} %>/>
    </table>

        <asp:Button ID="btnComprar" runat="server" Text="Button"  />
        
    </article>
</asp:Content>
