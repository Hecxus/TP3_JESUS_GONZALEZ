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
        public List<Articulos> listaArticulos { get; set; }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}