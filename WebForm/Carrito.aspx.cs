using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulos> listaArticulos { get; set; }
        public Articulos Aux { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulos> listAux;
            try
            {
                listAux = negocio.listar();
                int idAux = Convert.ToInt32(Request.QueryString["id"]); // esto
                Aux = listAux.Find(x => x.ID == idAux);

                if (Session["articulosAdd"] == null )
                {
                    listaArticulos = new List<Articulos>();
                    Session.Add("articulosAdd", listaArticulos);
                    
                }
                else
                {
                    listaArticulos = (List<Articulos>)Session["articulosAdd"];
                    listaArticulos.Add(Aux);
                    Session["articulosAdd"] = listaArticulos;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}