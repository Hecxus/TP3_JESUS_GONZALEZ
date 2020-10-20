using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Detalle : System.Web.UI.Page
    {

        public List<Articulos> listaArticulos { get; set; }
        public Articulos articulo { get; set; }

        public CarritoNegocio carrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            articulo = negocio.BuscarArticuloPorId(id);

            if (Session["carrito"] == null)
            {
                throw new Exception("Carrito nulo!");
            } else
            {
                carrito = (CarritoNegocio)Session["carrito"];
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {

            carrito.AgregarACarrito(articulo);
        }
    }
}