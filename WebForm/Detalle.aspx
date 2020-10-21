<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function MensajeCompra() {
            alert("Agregado al carrito!")
        }
    </script>


    <section>
    <div class="jumbotron">
    <div >
        <h4>&nbsp;</h4>
        <h4>&nbsp;</h4>
        <h2>Detalle del articulo:</h2>
    </div>
    <div>
        <img style="float:left; height: 387px; width: 441px;" src=" <%=articulo.Imagen%>" alt="Imagen de prueba" />
            </div>
        <div>
        <h4 >&nbsp;</h4>
            <h4 >&nbsp;</h4>
            <h4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre: <%=articulo.Nombre%></h4>
        <h4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion:  <%=articulo.Descripcion%></h4>
            <h4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Marca:  <%=articulo.marca%></h4>
            <h4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Categoria:  <%=articulo.categoria%></h4>
            <br />
        <h3 style="margin-bottom:300px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio: $   <%=articulo.Precio%> </h3>
            <a href="Default.aspx" class="btn btn-primary"
                style=" 
                  background-color: #339FFF;
                  border: none;
                  color: white;
                  padding: 15px 40px;
                  text-align: center;
                  text-decoration: none;
                  display: inline-block;
                  font-size: 16px;">Volver</a>&nbsp;&nbsp;&nbsp;

            <asp:Button CssClass="Button" OnClick="Agregar_Click" ID="Agregar" runat="server" Text="Agregar al carrito" OnClientClick="MensajeCompra()"
                style=" 
                  background-color: #339FFF;
                  border: PowderBlue;
                  color: white;
                  padding: 15px 10px;
                  text-align: center;
                  text-decoration: none;
                  display: inline-block;
                  font-size: 16px;" Width="191px"/>


    </div>
    </div>
    </section>
</asp:Content>
