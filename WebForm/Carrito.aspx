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
          <%--<th scope="col">Cantidad</th>--%>
          <th scope="col">Eliminar</th>
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
                      <%--<td>#Boton eliminar?</td>--%>
                      <td><a href="Carrito.aspx?deleteid=<%= articulos.ID.ToString() %> " class="btn btn-primary"  onclick="evaluarBotonCompra()">X</a></td>
                    </tr>
                </tbody>
        <%} %>
    </table>
        <div> <asp:Label ID="lblSinElementos" runat="server" Text="No se ha agregado ningun elemento al carrito aun." style="display:block; text-align:center;"></asp:Label></div>
 

        <asp:Button ID="btnComprar" runat="server" Text="Comprar" style="display:block; text-align:right;" OnClick="btnComprar_Click" Width="72px" />
 

        <asp:Label ID="lblTotal" runat="server" Text=" x " style="display:block; text-align:right;"></asp:Label>
               <div style="display: inline-block;">
        </div>
                   <asp:Button ID="btnVaciar" runat="server" Text="Vaciar carrito" OnClick="btnVaciar_Click" Height="25px" />
    </article>
</asp:Content>
