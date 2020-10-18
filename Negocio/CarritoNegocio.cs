using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CarritoNegocio
    {
        Dominio.Carrito carrito { get; set; }


        public CarritoNegocio()
        {
            carrito = new Dominio.Carrito();
            //carrito.listaArticulos = new List<Dominio.Articulos>;
        }

        public List<Articulos> GetListaArticulos()
        {
            return carrito.listaArticulos;
        }

        public void AgregarACarrito(Articulos _articulo)
        {
            carrito.listaArticulos.Add(_articulo);
           
        }
    }
}
