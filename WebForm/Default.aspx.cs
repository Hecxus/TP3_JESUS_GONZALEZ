using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebForm
{
    public partial class _Default : Page
    {
        public List<Articulos> articulosAMostrar { get; set; }
        public CarritoNegocio carrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtiene el carrito, si no fue generado antes, lo genera y adhiere a la sesion
            if (Session["carrito"]==null)
            {
                carrito = new CarritoNegocio();
                Session.Add("carrito", carrito);
            } else
            {
                carrito = (CarritoNegocio)Session["carrito"];
            }
            

            // Muestra en la pagina Default la lista de articulos disponibles en la base
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulosAMostrar = negocio.listar();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            ////string Value1 = btn.CommandArgument.ToString();
            //string Value1 = btn.Attributes["CustomParameter"].ToString();
            //throw new Exception(Value1);
        }


    }
}