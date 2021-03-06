﻿using Dominio;
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

        // nuevo
        public CarritoNegocio carrito { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {

            ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:evaluarBotonCompra(); ", true);
            


            if (Session["carrito"] == null)
            {
                throw new Exception("Carrito nulo!");
            }
            else
            {
                // Cada vez que se ingresa a la pagina carrito se actualiza la variable de lista con los articulos
                carrito = (CarritoNegocio)Session["carrito"];  
                listaArticulos = carrito.GetListaArticulos();
            }

            if (Request.QueryString["deleteid"]!=null)
            {
                BorrarPorId(Convert.ToInt32(Request.QueryString["deleteid"]));
            }
            //ArticuloNegocio negocio = new ArticuloNegocio();
            //List<Articulos> listAux;
            //try
            //{
            //    listAux = negocio.listar();
            //    int idAux = Convert.ToInt32(Request.QueryString["id"]); // esto
            //    Aux = listAux.Find(x => x.ID == idAux);

            //    if (Session["articulosAdd"] == null )
            //    {
            //        listaArticulos = new List<Articulos>();
            //        Session.Add("articulosAdd", listaArticulos);

            //    }
            //    else
            //    {
            //        listaArticulos = (List<Articulos>)Session["articulosAdd"];
            //        listaArticulos.Add(Aux);
            //        Session["articulosAdd"] = listaArticulos;
            //    }

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            CalcularTotal();
            if (carrito.GetListaArticulos().Count == 0)
            { 
                btnComprar.Visible = false;
            btnVaciar.Visible = false;
            }
            

        }

        void BorrarPorId(int i)
        {
            int index = -1;
            index = carrito.GetListaArticulos().FindIndex(x => x.ID == i);
            if (index != -1) 
                carrito.GetListaArticulos().RemoveAt(index);
        }

        public string EvaluarBotonCompra()
        {
            if (listaArticulos.Count > 0)
            {

                lblSinElementos.Visible = false;
                return "true";
            }
            lblSinElementos.Visible = true;
            return "false";
        }
        void CalcularTotal()
        {
            float total = 0;
            if (listaArticulos!=null)
            { 
               foreach (Articulos articulo in listaArticulos)
                {
                    total += articulo.Precio;
                }
            }
            lblTotal.Text = "El valor total es: $"+total.ToString();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "s", "window.alert('Compra realizada!');", true);
        }

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            if (carrito.GetListaArticulos().Count!=0)
                carrito.GetListaArticulos().Clear();
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "s", "window.alert('No hay articulos para borrar!');", true);

            btnComprar.Visible = false;
            btnVaciar.Visible = false;
        }
    }
}