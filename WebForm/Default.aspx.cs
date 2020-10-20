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
                if (Request.QueryString["searchText"] != null)
                {
                    string texto = Request.QueryString["searchText"].ToUpper();
                    articulosAMostrar = negocio.listarConBusqueda("UPPER(nombre) like '%"+ texto +"%'");
                }else
                { 
                    articulosAMostrar = negocio.listar();
                }

            }
            catch (Exception)
            {
                throw;
            }
            if (articulosAMostrar.Count==0)
            {
                lblBuscador.Text = "La busqueda no trajo resultados, pruebe otro nombre.";
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            ////string Value1 = btn.CommandArgument.ToString();
            //string Value1 = btn.Attributes["CustomParameter"].ToString();
            //throw new Exception(Value1);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string param = "~/Default.aspx?searchText=" + searchText.Text;
            Response.Redirect(param);
        }
    }
}